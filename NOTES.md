Keep in mind that anytime we update a .csproj file, we need to run dotnet restore to download and install updated packages.

It's also essential to ensure that we run console commands within the correct project.

Identify the simplest possible behavior the program must exhibit.
Write a coded test for this behavior.
Before coding, confirm the test fails.
Implement the behavior with the least amount of code possible.
Run the automated test to confirm it passes. If it doesn't, revisit step 4.
Confirm all previous tests still pass. If it doesn't, revisit step 4.
Check if code can be refactored. If so, refactor and repeat step 6.
Commit your passing code.
Repeat this process with the next simplest behavior.

