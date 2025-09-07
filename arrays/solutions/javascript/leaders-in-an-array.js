/* author: @Barkty */

class ArrayLeaders {
  /*
    Complexity
    Time: O(n) → single pass from right to left.
    Space: O(k) → stores leaders, then reverses
  */
  static findAllLeaders(arr) {
    const result = [];
    let n = arr.length;

    let leader = arr[n - 1];
    result.push(leader);

    for (let i = n - 2; i >= 0; i--) {
      if (arr[i] >= leader) {
        leader = arr[i];
        result.push(leader);
      }
    }

    result.reverse();
    console.log(result.join(" "));
  }

  /*
    Complexity
    Time: O(n) → single pass from right to left.
    Space: O(k) → leaders stored in stack
  */
  static findAllLeadersUsingStack(arr) {
    let n = arr.length;
    let leader = arr[n - 1];

    const stack = [];
    stack.push(leader);

    for (let i = n - 2; i >= 0; i--) {
      if (arr[i] >= leader) {
        leader = arr[i];
        stack.push(leader);
      }
    }

    // Pop from stack to restore order
    while (stack.length > 0) {
      process.stdout.write(stack.pop() + " ");
    }
    console.log(); // newline
  }
}

// Example usage
const arr1 = [16, 17, 4, 3, 5, 2];
ArrayLeaders.findAllLeaders(arr1);        // Output: 17 5 2
ArrayLeaders.findAllLeadersUsingStack(arr1); // Output: 17 5 2

const arr2 = [1, 2, 3, 4, 5, 2];
ArrayLeaders.findAllLeaders(arr2);        // Output: 5 2
ArrayLeaders.findAllLeadersUsingStack(arr2); // Output: 5 2
