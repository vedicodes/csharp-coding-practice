function outerFunction() {
    var outerVariable = 10;
    var innerFunction = () => {
        console.log(outerVariable);
        outerVariable += 10;
    };
    return innerFunction;
}
var closureFunction = outerFunction();
closureFunction();
closureFunction();
closureFunction();