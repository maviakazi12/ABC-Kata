## [ABC KATA](https://myobconfluence.atlassian.net/wiki/spaces/FMA/pages/9394815832/ABC+Kata)

### Pseudocode

- Set of letter blocks => will store in a list of strings {"OB,"PK"} </br>
- Make a class to handle player input and the game logic</br>
- The class will contain a method that will check the word against the set of letter blocks</br>
#### Method:
- Use a foreach loop to iterate through the "WORD"</br>
- Use FindIndex list method to find the letter match:</br>
- Inside FindIndex method use IndexOf string method to find if the first letter of word exists in the string.</br>
- If letter is found remove it from the list using .Remove list method. Loop continues</br>
- if it returns -1 which means letter is not found. Immediately return false</br>
- Once the foreach loop successfully finishes and finds all letters, return true</br>