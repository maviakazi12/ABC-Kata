Console.WriteLine("Hello, World!");
List<string> letterBlocks = new List<string> {"BO","XK","DQ","CP","NA","GT","RE","TG","QD","FS","JW","HU","VI","AN","OB","ER","FS","LY","PC","ZM"};
Console.WriteLine("Type a word to check if it can be spelled using the blocks");
string word = (Console.ReadLine().ToUpper());
WordGame newGame = new WordGame(word, letterBlocks);
newGame.CheckIfWordExists();

public class WordGame {
    private string word;
    private List<string> letterBlocks;
    public WordGame(string word, List<string> letterBlocks){
        this.word = word;
        this.letterBlocks = letterBlocks;
    }
    public void CheckIfWordExists(){
        foreach (var letter in word){
            int index = letterBlocks.FindIndex(block => block.Contains(letter));
            if (index<0){
                Console.WriteLine("False");
                return;
            }else{
                letterBlocks.RemoveAt(index);
            }
        };
        Console.WriteLine("TRUE");
    }
};