var even = 4, odd = 5;

console.log(isOdd((even)));
console.log(isOdd((odd)));


function isOdd(number) {
    if (number % 2 == 0) {
        return true;
    }
    else {
        return false;
    }
}