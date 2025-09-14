
using System.Diagnostics;

// Test cases for MultiplesOf3and5 methods

void Test(int limit, int expected)
{
	int result1 = EulerCodes.MultiplesOf3and5.Solve(limit);
	int result2 = EulerCodes.MultiplesOf3and5.SolveInLINQ(limit);
	Debug.Assert(result1 == expected, $"Solve({limit}) failed: got {result1}, expected {expected}");
	Debug.Assert(result2 == expected, $"SolveInLINQ({limit}) failed: got {result2}, expected {expected}");
}

// Test cases
Test(10, 23);
Test(1, 0);
Test(16, 60);
Test(100, 2318);
Test(1000, 233168);

Console.WriteLine("All assertions passed.");
