function merge(arrOne, arrTwo) {
  const newArr = [];
  let i = 0;
  let j = 0;

  while (i != arrOne.length && j != arrTwo.length) {
    if (arrOne[i] < arrTwo[j]) {
      newArr.push(arrOne[i]);
      i++;
    } else {
      newArr.push(arrTwo[j]);
      j++;
    }
  }

  while (i != arrOne.length) {
    newArr.push(arrOne[i]);
    i++;
  }

  while (j != arrTwo.length) {
    newArr.push(arrTwo[j]);
    j++;
  }

  return newArr;
}

function mergeSort(arr) {
  if (arr.length === 1) return arr;

  const middle = Math.floor(arr.length / 2);
  var left = mergeSort(arr.splice(0, middle));
  var right = mergeSort(arr);

  return merge(left, right);
}

console.log(mergeSort([1, 2, 3, 6, 4]));
