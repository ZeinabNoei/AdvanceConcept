using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Threading;
using System.Linq.Expressions;
using System.Collections;
using System.Reflection;
namespace ExpressionTrees
{
    public class Program
    {

        static void Main(string[] args)
        {
            //ParallelLinqSum();
            //Cancellation();
            //ShowSampleExpressionTree();
            //SearchRacers("This", "bullshit");
            BuildExpression();

            Console.ReadKey();
        }

        static int[] GenerateData()
        {
            const int arraySize = 100000000;
            var data = new int[arraySize];
            var r = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                data[i] = r.Next(40);
            }

            return data;
        }

        static void ParallelLinqSum()
        {
            int[] data = GenerateData();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var sumParallel = (from n in data.AsParallel()
                               where n < 20
                               select n).Sum();
            stopWatch.Stop();
            TimeSpan parallelLinqSpan = stopWatch.Elapsed;

            stopWatch.Restart();
            var sumRegular = (from n in data where n < 20 select n).Sum();
            stopWatch.Stop();
            TimeSpan regularTimeSpan = stopWatch.Elapsed;

            Console.WriteLine("parallel linq result: " + sumParallel);
            Console.WriteLine("parallel linq time: " + parallelLinqSpan);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("regular linq result: " + sumRegular);
            Console.WriteLine("regular linq time: " + regularTimeSpan);
        }

        static void Partitioners()
        {
            int[] data = GenerateData();
            var sum = (from x in Partitioner.Create(data, true).AsParallel()
                       where x < 20
                       select x).Sum();
        }

        static void Cancellation()
        {
            int[] data = GenerateData();

            var cts = new CancellationTokenSource();

            new Thread(() =>
            {
                try
                {
                    var sum = (from x in data.AsParallel().WithCancellation(cts.Token)
                               where x < 80
                               select x).Sum();
                    Console.WriteLine("query finished, sum: {0}", sum);
                }
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }).Start();


            Console.WriteLine("query started");
            Console.Write("cancel? ");
            int input = Console.Read();
            if (input == 'Y' || input == 'y')
            {
                // cancel!
                cts.Cancel();
            }
        }

        static void DisplayTree(int indent, string message, Expression expression)
        {
            Func<int, string> generateIndent = indentation =>
            {
                string result = "|_";
                for (int i = 0; i < indentation; i++)
                {
                    result += "____";
                }

                return result;
            };

            string output = String.Format("\r\n|\r\n{0} {1} ! NodeType: {2}; Expr: {3} ",
                  generateIndent(indent), message, expression.NodeType, expression);

            indent++;
            switch (expression.NodeType)
            {
                case ExpressionType.Lambda:
                    Console.WriteLine(output);
                    LambdaExpression lambdaExpr = (LambdaExpression)expression;
                    foreach (var parameter in lambdaExpr.Parameters)
                    {
                        DisplayTree(indent, "Parameter", parameter);
                    }
                    DisplayTree(indent, "Body", lambdaExpr.Body);
                    break;
                case ExpressionType.Constant:
                    ConstantExpression constExpr = (ConstantExpression)expression;
                    Console.WriteLine("{0} Const Value: {1}", output, constExpr.Value);
                    break;
                case ExpressionType.Parameter:
                    ParameterExpression paramExpr = (ParameterExpression)expression;
                    Console.WriteLine("{0} Param Type: {1}", output, paramExpr.Type.Name);
                    break;
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                case ExpressionType.Modulo:
                case ExpressionType.AndAlso:
                case ExpressionType.GreaterThan:
                    BinaryExpression binExpr = (BinaryExpression)expression;
                    if (binExpr.Method != null)
                    {
                        Console.WriteLine("{0} Method: {1}", output, binExpr.Method.Name);
                    }
                    else
                    {
                        Console.WriteLine(output);
                    }
                    DisplayTree(indent, "Left", binExpr.Left);
                    DisplayTree(indent, "Right", binExpr.Right);
                    break;
                case ExpressionType.MemberAccess:
                    MemberExpression memberExpr = (MemberExpression)expression;
                    Console.WriteLine("{0} Member Name: {1}, Type: {2}", output,
                       memberExpr.Member.Name, memberExpr.Type.Name);
                    DisplayTree(indent, "Member Expr", memberExpr.Expression);
                    break;
                case ExpressionType.Call:
                    MethodCallExpression methodCallExpr = (MethodCallExpression)expression;
                    Console.WriteLine("{0} Method: {1}", output, methodCallExpr.Method.Name);
                    foreach (var argument in methodCallExpr.Arguments)
                    {
                        DisplayTree(indent, "Argument", argument);

                    }
                    DisplayTree(indent, "Method Call", methodCallExpr.Object);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("{0} {1}", expression.NodeType, expression.Type.Name);
                    break;
            }
        }

        static void ShowSampleExpressionTree()
        {
            //Expression<Func<Racer, bool>> expression = r => r.Country == "Brazil" && r.Wins > 6;
            Expression<Func<Racer, int, bool>> expression = (r, index) => r.LastName.StartsWith("A") && index % 2 != 0;
            //Func<Racer, int, bool> exp = (r, index) => r.LastName.StartsWith("A") && index % 2 != 0;

            DisplayTree(0, "Lambda", expression);
        }

        static void SearchRacers(params string[] keywords)
        {
            var predicate = PredicateBuilder.False<Racer>();

            foreach (string keyword in keywords)
            {
                string temp = keyword;
                predicate = predicate.Or(r => r.Description.Contains(temp));
            }

            IQueryable<Racer> dataContext = Formula1.GetChampions().AsQueryable();
            foreach (var racer in dataContext.Where(predicate))
            {
                Console.WriteLine("Racer: {0}, Description: {1}", racer.ToString(), racer.Description);
            }
        }

        static void BuildExpression()
        {
            //Expression<Func<string, bool>> f = s => s.Length < 5;

            // Build expression here...
            var p = Expression.Parameter(typeof(string), "p");
            var five = Expression.Constant(5);
            var stringlenth = Expression.Property(p, "Length");
            var lessthan = Expression.LessThan(stringlenth, five);
            var lambda = Expression.Lambda<Func<string, bool>>(lessthan, p);
            //tabdil be delegate
            var del = lambda.Compile();
            //var Result= del.Invoke("paradays");
            var Result = del("paradays");

            //test it here...

            //Expression<Func<string, bool>> exp = e => e.Year >=1998;
            var e = Expression.Parameter(typeof(string), "e");
            var y = Expression.Constant(1998);
            var stringlengh = Expression.Property(e, "Length");
            var lessthree = Expression.GreaterThanOrEqual(stringlengh, y);
            var lambda2 = Expression.Lambda<Func<string, bool>>(lessthree, e);
            var que = lambda2.Compile();
            var result2 = que.Invoke("2000");


            //Expression<Func<Racer, int, bool>> expression = (r, index) => r.LastName.StartsWith("A") && index % 2 != 0;
            var Zero = Expression.Constant(0);
            var Two = Expression.Constant(2);
            var A = Expression.Constant("A");

            var R = Expression.Parameter(typeof(Racer), "r");
            var Index = Expression.Parameter(typeof(int), "i");

            var Divid = Expression.Divide(Index, Two);
            var ResultDivid = Expression.NotEqual(Divid, Zero);

            //LastName = Expression.Property(R, "LastName");
            var LastName = Expression.MakeMemberAccess(R, typeof(Racer).GetMember("LastName").FirstOrDefault());
            //var SatrtWith = Expression.Call(LastName, typeof(string).GetMethod("StartWith"));
            MethodInfo StartsWith = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
            var call = Expression.Call(LastName, StartsWith, A);

            //var call = Expression.Property(LastName, "", A);
            var andAlso = Expression.AndAlso(call, ResultDivid);
            var lambda1 = Expression.Lambda<Func<Racer, int, bool>>(andAlso, new[] { R, Index });
            Func<Racer, int, bool> _result = lambda1.Compile();

            var _resu = _result.Invoke(Formula1.GetChampions().FirstOrDefault(), 1);
            //var NameStart = Expression


            //Expression<Func<Racer, int, bool>> expression = (r, index) => r.LastName.StartsWith("A") ;

            var AA = Expression.Constant("A");
            var RR = Expression.Parameter(typeof(Racer), "r");
            var II = Expression.Parameter(typeof(int), "i");
            var LastNam = Expression.MakeMemberAccess(RR, typeof(Racer).GetMember("LastName").FirstOrDefault());
            MethodInfo SW = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
            var calls = Expression.Call(LastNam, SW, AA);
            var Lambda3 = Expression.Lambda<Func<Racer, bool>>(RR, II);

        }
    }
}
