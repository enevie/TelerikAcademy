var number = 1732;
var secondNumber = 9999799;
var thirdNumber = 777877;

console.log(CheckThirdDigit(number));
console.log(CheckThirdDigit(secondNumber));
console.log(CheckThirdDigit(thirdNumber));

function CheckThirdDigit(number) {
    var result = number / 100;
    var checkResult = (result % 10) | 0;

    if (checkResult == 7) {
        return true;
    }
    return false;
}