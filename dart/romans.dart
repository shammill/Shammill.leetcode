// convert roman numerals to real numbers
class Solution {
  Map<String, int> romans = {
    "I": 1,
    "IV": 4,
    "V": 5,
    "IX": 9,
    "X": 10,
    "XL": 40,
    "L": 50,
    "XC": 90,
    "C": 100,
    "CD": 400,
    "D": 500,
    "CM": 900,
    "M": 1000,
  };

  int romanToInt(String numerals) {
    int result = 0;
    for (int i = 0; i < numerals.length; i++) {
      String numeral = getNumeral(numerals, i);

      if (numeral.length > 1) {
        i++;
      }
      result += romans[numeral]!;
    }
    return result;
  }

  String getNumeral(String numerals, int i) {
    var currentNumeral = numerals[i];
    int nextIndex = i + 1;
    bool considerNextNumeral = nextIndex < numerals.length;
    String nextNumeral = considerNextNumeral ? numerals[nextIndex] : "";
    String combinedNumeral = "$currentNumeral$nextNumeral";

    return romans[combinedNumeral] != null ? combinedNumeral : currentNumeral;
  }
}
