Console.WriteLine("Welcome to the ABC Kata Game!");
Console.WriteLine("Type a word to check if it can be spelled using the blocks");
string word = Console.ReadLine().ToUpper();
List<string> usedBlocks = new List<string>(); 
WordGame wordGame = new WordGame(word, usedBlocks);
Console.WriteLine(wordGame.CheckIfWordExists(0));


public class WordGame {
    private readonly string word;
    private List<string> letterBlockList;
    private List<string> usedBlocks;
    public WordGame(string word, List<string> usedBlocks){
        this.word = word;
        this.usedBlocks = usedBlocks;
        letterBlockList = SelectRandomList();
    }
    private static List<string> SelectRandomList(){
        List<string> list1 = new List<string> {"BO","XK","DQ","CP","NA","GT","RE","TG","QD","FS","JW","HU","VI","AN","OB","ER","FS","LY","PC","ZM"};
        List<string> list2 = new List<string> {"XT", "LW", "RM", "VF", "PK", "JN", "SQ", "DY", "BZ", "CH","UG", "AO", "MT", "EX", "QP", "HC", "ZF", "NK", "WL", "YV"};
        Random random = new Random();
        List<string> randomizedList = random.Next(2) == 0 ? list1 : list2;
        Console.WriteLine("The letter block list is: " + string.Join(", ", randomizedList));
        return randomizedList;
    }
    public bool CheckIfWordExists(int wordIndex){
    if (wordIndex == word.Length){
        return true;
    }
    char letter = word[wordIndex];
    for (int i = letterBlockList.Count - 1; i >= 0; i--){
        if (letterBlockList[i].Contains(letter)){
            usedBlocks.Add(letterBlockList[i]);
            letterBlockList.RemoveAt(i);
        if (CheckIfWordExists(wordIndex+1))return true;
        letterBlockList.Insert(i,usedBlocks[^1]);
        usedBlocks.RemoveAt(usedBlocks.Count-1);
        }
        
    }
    return false;
}
}



