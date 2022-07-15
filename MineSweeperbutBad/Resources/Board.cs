using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperbutBad.Resources
{
    interface IGameboard
    {
        void ChangeBoardPiece(string x);
    }

    class GameBoard : IGameboard
    {
        private string[][] _blankArray;     //default array that other arrays can cast to; I may not need this
        private bool[][] _backendArray;     //array for mines and such; 0 for no mine, 
        private string[][] _frontendArray;  //what the user sees, contains markers and stuff

        private string _blankPiece = "[ ]"; //sets a default boardpiece
        GameBoard()
        {

        }

        public void ChangeBoardPiece(string BoardPiece) => _blankPiece = BoardPiece;


    }
}
