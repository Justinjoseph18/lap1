// class LINQ
// {
//     static void Main()
//     {
//         // The Three Parts of a LINQ Query:
//         // 1. Data source.
//         int[] numbers = {1, 2, 3, 4, 5, 6 };

//         // 2. Query creation.
//         var numQuery =
//             from num in numbers
//             where (num % 2) == 0
//             select num;

//         // 3. Query execution.
//         foreach (int num in numQuery)
//         {
//             Console.Write(num);
//         }
//     }
// }
// sorting 
// class LINQ
// {
//     static void Main()
//     {
//         // The Three Parts of a LINQ Query:
//         // 1. Data source.
//         string[] words = {"hai","cat","hello","cow","goat"};

//         // 2. Query creation.
//         var query =
//             from i in words 
//             orderby i.Length descending
//             select i;

//         // 3. Query execution.
//         foreach (var i in words)
//         {
//             Console.Write(" "+ i);
//         }
//     }
// }