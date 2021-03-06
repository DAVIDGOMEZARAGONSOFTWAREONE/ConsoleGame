using System;

namespace ConsoleGame
{
  internal class Game : SuperGame
  {
    // Mover cursor
    public new static void UpdatePosition(string KeyPressed,out int X,out int Y){
      X=0;
      Y=0;
      switch(KeyPressed){
        case "DownArrow":Y++;
        break;
        case "UpArrow":Y--;
        break;
        case "LeftArrow":X--;
        break;
        case "RightArrow":X++;
        break;
      }
    }

    // Actualizar sentido del cursor
    public new static char UpdateCursor(string KeyPressed){
      char Symbol='0';
      switch(KeyPressed){
        case "DownArrow":Symbol='v';
        break;
        case "UpArrow":Symbol='^';
        break;
        case "LeftArrow":Symbol='<';
        break;
        case "RightArrow":Symbol='>';
        break;  
      }
      return Symbol;
    }

    // Gestionar los límites del tablero
    public new static int KeepInBounds(int Coordinate, int MaxValue){
      int Keep=0;
      if(Coordinate>=MaxValue){
        Keep=0;
      }else if(Coordinate<=0){
        Keep=MaxValue;
      }else{
        Keep=Coordinate;
      }
      return Keep;
    }

    // Jugador anota un punto
    public new static bool DidScore(int XChar, int YChar,int XFruit,int YFruit ){
      bool control=false;
      if (XChar==XFruit && YChar==YFruit){
        control=true;
      }
      return control;
    }
  }
}
