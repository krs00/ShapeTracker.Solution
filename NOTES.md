Keep in mind that anytime we update a .csproj file, we need to run dotnet restore to download and install updated packages.

It's also essential to ensure that we run console commands within the correct project.


1. Identify the simplest possible behavior the program must exhibit.
2. Write a coded test for this behavior.
3. Before coding, confirm the test fails.
4. Implement the behavior with the least amount of code possible.
5. Run the automated test to confirm it passes. If it doesn't, revisit step 4.
6. Confirm all previous tests still pass. If it doesn't, revisit step 4.
7. Check if code can be refactored. If so, refactor and repeat step 6.
8. Commit your passing code.
9. Repeat this process with the next simplest behavior.


Before we move on, remember this — if we resolve a compiler error only to get many, many more compiler errors, that does not automatically mean we're on the wrong track; it just means we've moved on to the next issue in our code.

testing guideline to follow: for each method, there should be a separate test for each possible outcome.


Going forward, remember that whenever we use static data, we need to create a Dispose() method to clean up between each test, and that we'll need to have our test classes extend from the IDisposable interface.



