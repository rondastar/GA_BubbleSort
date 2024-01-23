# GA_BubbleSort

Pseudocode explaining bubble sort

Get the length of the array

Set a flag to indicate whether elements have been swapped during a loop through

A while loop runs as long as the swap flag indicates that a swap occurred. 
At the beginning of the while loop, set the swap flag to false. If no swap occurs, that means all elements are sorted.

In a for loop starting at element 1 and looping through to the final element,
Compare the element with the previous element (element - 1).
If the current element is less than the previous element, swap the elements.
A temporary placeholder needs to store one of the values (A). 
The other value (B) is assigned to the array in the place of the value that is stored in the temporary value (A).
Then the temporary value is assigned to the array in the place of the other value (B).

The loop continues until no swap occurs in the array or the for loop has reached the last element,
whichever occurs first.
