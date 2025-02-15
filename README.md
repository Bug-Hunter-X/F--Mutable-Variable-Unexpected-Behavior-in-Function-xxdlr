# F# Mutable Variable Unexpected Behavior

This example demonstrates a common pitfall in F# when working with mutable variables and functions.  The unexpected behavior arises because functions in F#, by default, do not modify their input arguments.  Even if the input argument is a mutable variable, the function creates a copy of the value and works with the copy.  Only explicit assignments to the mutable variable within the function will actually change the variable's value. 

## The Bug

The `bug.fs` file contains code that illustrates this issue.  The function `addOne` takes a mutable variable `x` as input, adds one to it, and returns the new value.  However, the original `x` remains unchanged because the function does not update the passed-in variable. 

## The Solution

The `bugSolution.fs` file provides a solution where we explicitly modify the mutable variable within the function.  This ensures that the changes are reflected in the original variable.

## Running the code

To run the code, you'll need to have the F# compiler installed. You can then compile and run both files to see the difference in behavior.