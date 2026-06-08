// //Simulamos una conexión a una base de datos. Crea una excepción personalizada llamada DatabaseException que tenga una propiedad ErrorCode (entero). En tu código principal, lanza esta excepción con diferentes códigos (ej. 404 o 500) y usa la palabra clave when en los bloques catch para dar una respuesta diferente según el código de error.
// using System.Collections;

// namespace test;
// class Program{
//     public static void Main(){
//         Cards card_1 = new Cards(1,CardType.NORMAL,CardColor.BLUE);
//         Cards card_2 = new Cards(2,CardType.NORMAL,CardColor.RED);

//         try{
//             Cards card = new Cards(100,CardType.NORMAL,CardColor.GREEN);
//             //Cards card = Cards.getCard(1,CardType.NORMAL,CardColor.BLUE);

//             card.getInfo();
//         }
//         catch(InvalidCardException e) when(e.ErrorCode == 406){
//             Console.WriteLine(e.Message);
//         }
//         catch(CardNotFoundedException e) when(e.ErrorCode == 404){
//             Console.WriteLine(e.Message);
//         }
//     }
// }
// public class Cards{
//     private static List<Cards> cards = new List<Cards>();
//     public byte num;
//     public CardType type;
//     public CardColor color;
//     public Cards(byte num, CardType type, CardColor color){
//         if(type == CardType.COLOR_CHANGE && color != CardColor.BLACK)
//             throw new InvalidCardException(406,"Carta imposible");

//         else if(!(num >= 0 && num <= 9))
//             throw new InvalidCardException(406,"Carta imposible");

//         this.num = num;
//         this.type = type;
//         this.color = color;
//         cards.Add(this);
//     }
//     public void getInfo(){
//         Console.WriteLine($"Numero: {num}");
//         Console.WriteLine($"Tipo: {type}");
//         Console.WriteLine($"Color: {color}");
//     }
//     public static Cards getCard(byte num, CardType type, CardColor color){
//         foreach(Cards card in cards){
//             if(card.num == num && card.type == type && card.color == color)
//                 return card;
//         }
//         throw new CardNotFoundedException(404,"Carta no encontrada");
//     }
// }
// public enum CardType{
//     NORMAL,
//     REVERSE,
//     COLOR_CHANGE,
//     PLUS_FOUR
// }
// public enum CardColor{
//     BLACK,
//     BLUE,
//     RED,
//     YELLOW,
//     GREEN
// }

// public class InvalidCardException : Exception
// {
//     public int ErrorCode;
//     public InvalidCardException(int errorCode,string Message) : base(Message){
//         ErrorCode = errorCode;
//     }
// }
// public class CardNotFoundedException : Exception
// {
//     public int ErrorCode;
//     public CardNotFoundedException(int errorCode, string Message) : base(Message){
//         ErrorCode = errorCode;
//     }
// }