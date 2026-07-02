public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxs = new HashSet<char>[9];

        for(int i = 0 ; i<9;i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxs[i] = new HashSet<char>();
        }

        for(int i = 0; i<9;i++){
            for(int j = 0; j<9;j++){
                char value = board[i][j];
                if(value == '.'){
                    continue;
                }
                int box = i/3 * 3 + j/3;
                if(!rows[i].Add(value)){
                    return false;
                }
                if(!cols[j].Add(value)){
                    return false;
                }
                if(!boxs[box].Add(value)){
                    return false;
                }
            }
        }
        return true;
    }
}
