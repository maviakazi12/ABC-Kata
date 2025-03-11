Console.WriteLine("Welcome to the ABC Kata Game!");
Console.WriteLine("Type a word to check if it can be spelled using the blocks");
string word = (Console.ReadLine().ToUpper());
WordGame newGame = new WordGame(word);
newGame.CheckIfWordExists();

public class WordGame {
    private string word;
    private List<string> letterBlocks;
    public WordGame(string word){
        this.word = word;
        letterBlocks = SelectRandomList();
    }
    private static List<string> SelectRandomList(){
        List<string> list1 = new List<string> {"BO","XK","DQ","CP","NA","GT","RE","TG","QD","FS","JW","HU","VI","AN","OB","ER","FS","LY","PC","ZM"};
        List<string> list2 = new List<string> {"XT", "LW", "RM", "VF", "PK", "JN", "SQ", "DY", "BZ", "CH","UG", "AO", "MT", "EX", "QP", "HC", "ZF", "NK", "WL", "YV"};
        Random random = new Random();
        return random.Next(2) == 0 ? list1 : list2;
    }
    public void CheckIfWordExists(){
        Console.WriteLine("The letter block list is: " + string.Join(", ", letterBlocks));
        foreach (var letter in word){
            int index = letterBlocks.FindIndex(block => block.Contains(letter));
            if (index<0){
                Console.WriteLine("Sorry! the List does not contain the word "+ word);
                return;
            }else{
                letterBlocks.RemoveAt(index);
            }
        };
        Console.WriteLine("The List contains the word "+ word);
    }
};