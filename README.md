# Pizza_Project_Updated
# Course_14_Programming_Advices

I have completed the update for the first project from Course 14 – Programming Advices, developed using C# .NET Forms.

Initial attempt :
(https://github.com/amzil-soukaina/Pizza_Project.git)

During the initial attempt, I faced an issue with a comma appearing at the beginning of the Toppings label.
Even though a condition was added in the previous version to handle this, it did not work correctly due to the logic relying on direct addition and removal of text.

Later, the project was completely rebuilt using a different algorithm.

Key improvements in the updated version:

Use of separate functions to calculate prices instead of performing calculations directly in UI events.

Separation of calculation logic from UI updates.

Fixed the comma issue in Toppings by:

Collecting all selected toppings in a single variable.

Resetting the variable on every change.

Rebuilding the label text from scratch based on the selected items.


Use of the Tag property in UI elements to store prices instead of passing them manually.

Setting some options to be checked by default when the form loads.


Result

The project now has cleaner, more readable, and maintainable code, which is easier to extend compared to the initial attempt.
