// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string word = "TREE";
// int count = 0;
// HashSet<(int,char)> letterIndex = new HashSet<(int,char)>();
// (int,char) letterAndIndex;

// for (int i = 0; i<word.Length; i++){
//     for (int j = 0; j<word.Length; j++){
//         if (word[i]== word[j]){
//             count++;
//         }
//     }
//     letterAndIndex = (count,word[i]);
//     letterIndex.Add(letterAndIndex);
//     count=0;
// }

// Console.WriteLine(string.Join(", ", letterIndex));

List<string> letterBlocks = new List<string>{"ET", "RE", "ES", "TR"};
List<string> usedBlocks = new List<string>(); 
Console.WriteLine(recursiveFunction(word, 0, letterBlocks));


bool recursiveFunction(string word, int index, List<string> letterBlocks){
    if (index == word.Length){
        return true;
    }

    char letter = word[index];
    for (int i = letterBlocks.Count - 1; i >= 0; i--){
        if (letterBlocks[i].Contains(letter)){
            usedBlocks.Add(letterBlocks[i]);
            letterBlocks.RemoveAt(i);
        if (recursiveFunction(word, index+1, letterBlocks)) return true;
        letterBlocks.Insert(i,usedBlocks[^1]);
        usedBlocks.RemoveAt(usedBlocks.Count-1);
        }
        
    }
    return false;

}

