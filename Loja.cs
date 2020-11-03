using System;
using System.Collections.Generic;

class Loja {
  private string nomeLoja =">>>>> E-Utilit <<<<<";
  
  public List<int> idProd = new List<int>{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49};


  public List<string> descricao = new List<string>{"10 COLOUR SPACEBOY PEN","SET/10 BLUE POLKADOT PARTY CANDLES","POTTING SHED SOW \'N\' GROW SET","PAPERWEIGHT KINGS CHOICE ","WOVEN BERRIES CUSHION COVER ","WHITE/PINK MINI CRYSTALS NECKLACE","SET/3 RED GINGHAM ROSE STORAGE BOX","MAGNETS PACK OF 4 VINTAGE LABELS ","WHITE CHRYSANTHEMUMS ART FLOWER","WHITE FRANGIPANI NECKLACE","SILVER FABRIC MIRROR","PINK  HONEYCOMB PAPER FAN","PINK BOUDOIR T-LIGHT HOLDER","BLACK CHERRY LIGHTS","GLASS CAKE COVER AND PLATE","DECORATION SITTING BUNNY","ANTIQUE MID BLUE FLOWER EARRINGS","VINTAGE LEAF CHOPPING BOARD  ","SNACK TRAY I LOVE LONDON","DECROTIVEVINTAGE COFFEE GRINDER BOX","IVORY ENCHANTED FOREST PLACEMAT","ANTIQUE SILVER TEA GLASS ETCHED","BLUE FELT HANGING HEART W FLOWER","PACK OF 12 COLOURED PENCILS","CLAM SHELL SMALL ","TWO DOOR CURIO CABINET","GREEN GOOSE FEATHER CHRISTMAS TREE ","MULTICOLOUR HONEYCOMB FAN","GREEN DROP EARRINGS W BEAD CLUSTER","BOTANICAL LILY GREETING CARD","SILVER DROP EARRINGS WITH FLOWER","CANDY SPOT BUNNY","WHITE WITH BLACK CATS PLATE","VEGETABLE MAGNETIC  SHOPPING LIST","FLOWER PURPLE CLOCK WITH SUCKER","VINTAGE CHRISTMAS GIFT SACK","found box","SET 10 CARDS SNOWY SNOWDROPS  17100","JUMBO SHOPPER VINTAGE RED PAISLEY","SET OF 4 ENGLISH ROSE PLACEMATS","FELTCRAFT HAIRBAND RED AND BLUE","BLUE GIANT GARDEN THERMOMETER","VINTAGE PAISLEY STATIONERY SET","SET OF 4 NAPKIN CHARMS CUTLERY","CARAVAN SQUARE TISSUE BOX","FRENCH PAISLEY CUSHION COVER ","GOLD FISHING GNOME","PINK BABY BUNTING","DROP DIAMANTE EARRINGS CRYSTAL","RED FLOCK LOVE HEART PHOTO FRAME"};

  public List<int> quantd = new List<int>{3, 7, 14, 18, 20, 21, 23, 37, 38, 40, 43, 50, 51, 54, 60, 62, 66, 68, 70, 71, 75, 82, 91, 100, 114, 130, 140, 145, 147, 148, 149, 153, 156, 158, 160, 179, 183, 186, 187, 191, 195, 207, 213, 220, 227, 228, 229, 230, 232, 238, 239, 247, 256, 265, 271, 278, 279, 281, 282, 290, 294, 297, 301, 308, 324, 327, 331, 334, 335, 336, 338, 339, 341, 345, 346, 347, 351, 358, 359, 365, 366, 380, 389, 392, 398, 403, 408, 412, 421, 423, 428, 432, 437, 440, 445, 446, 453, 472, 478, 481};

  public List<double> preco = new List<double>{10.65,9.13,0.66,175.69,15.5,206.4,194.7,3.26,2019.05,109.19,404.49,157.08,183.2,124.87,888.42,736.38,0.84,0.07,2.4,24.96,9.72,160.0,18.62,14.75,2.82,10.2,29.74,19.96,80.46,183.09,152.19,49.13,8.0,138.46,135.08,2.41,10.82,425.14,2028.25,5.13,20.38,5.76,199.33,192.44,2.62,201.84,170.92,5.0,0.87,537.83};


  public void NomeLj(){
  Console.WriteLine("{0,37}", nomeLoja);
  }
  
  public void Produtos(){
    int nId = 0; 
    NomeLj();
    Console.WriteLine("-----------------------------------------------------------");
    for(int i=0;i<idProd.Count;i++){
      Console.WriteLine("|{0,2}| {1,-35} |{2,3}|= {3, 9:c2}|",idProd[i],descricao[i],quantd[i],preco[i]);
    }
    Console.WriteLine("-----------------------------------------------------------");
    Console.Write("\nDigite o número do produto que deseja comprar: ");
    nId = int.Parse(Console.ReadLine());
    Console.Write("\nDigite a quantidade: ");
    int qntP = int.Parse(Console.ReadLine());

    if(quantd[nId]>0 & quantd[nId]>=qntP & nId >= 0 & nId <= 49){
      if (nId >= 0 & nId <= 49){
        Carrinho.carrinho.Add(nId);
        int attqnt = quantd[nId]-qntP;
        quantd[nId] = attqnt ;
        int attqntC = Carrinho.qntCar[nId]+qntP;
        Carrinho.qntCar[nId] = attqntC ;        
      }else{
        Console.Write("\nDigite o número do produto válido! \n>>>PRESSIONE ENTER PARA VOLTAR AS COMPRAS<<<");
        Console.ReadLine();
        Produtos();
      }
     }else{
       Console.Write("\n>>Quantidade solicitada não tem em estoque<< \n>>>PRESSIONE ENTER PARA VOLTAR AS COMPRAS<<<");
        Console.ReadLine();
        Produtos();
     }

  } 
 

    

  

}