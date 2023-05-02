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

