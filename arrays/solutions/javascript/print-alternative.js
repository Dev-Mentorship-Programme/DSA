/*author: @Barkty
*/

class PrintAlternative {
  static printAlternates(arr) {
    for (let i = 0; i < arr.length; i += 2) {
      process.stdout.write(arr[i] + " "); // prints on same line
    }
    console.log(); // new line
  }
}

// Example usage
const arr = [10, 20, 30, 40, 50];
PrintAlternative.printAlternates(arr);
