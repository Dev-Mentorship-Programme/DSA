/* author: @Barkty */

class SecondLargestElement {
  /*
    Complexity:
    Time: O(n) → only one scan.
    Space: O(1) → just two variables.
  */
  static findSecondLargest(arr) {
    if (arr.length < 2) return -1;

    let first = Number.MIN_SAFE_INTEGER;
    let second = Number.MIN_SAFE_INTEGER;

    for (const num of arr) {
      if (num > first) {
        second = first;
        first = num;
      } else if (num > second && num < first) {
        second = num;
      }
    }

    return second === Number.MIN_SAFE_INTEGER ? -1 : second;
  }
}

// Example usage
const arr1 = [12, 35, 1, 10, 34, 1];
console.log(SecondLargestElement.findSecondLargest(arr1)); // 34

const arr2 = [10, 5, 10];
console.log(SecondLargestElement.findSecondLargest(arr2)); // 5

const arr3 = [10, 10, 10];
console.log(SecondLargestElement.findSecondLargest(arr3)); // -1
