function matchArrayElement(array, match) {
    for (var index = 0; index < array.length; index++) {
        var element = array[index];

        if (typeof match === "object") {
            for (var key in match) {
                if (match.hasOwnProperty(key) && element.hasOwnProperty(key)) {
                    var matchVal = match[key];
                    var elemVal = element[key];

                    return matchVal == elemVal;
                }
            }
        }
        else {
            return (element == match)
        }
    }

    return false;
}