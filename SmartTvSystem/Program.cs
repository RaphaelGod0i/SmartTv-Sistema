// See https://aka.ms/new-console-template for more information

using SmartTvSystem;

SmartTv smartTv = new SmartTv();

int canal = 0;
string continuar = "";

Console.WriteLine("------------------------------------");
Console.WriteLine(    "S U P E R  T E L E V I S Ã O");
Console.WriteLine("------------------------------------");

smartTv.CanalAtual();
smartTv.VolumeAtual();

do
{

    Console.WriteLine("Deseja aumentar o volume, manter ou reduzir?");
    string opcaoVolume = Console.ReadLine();

        if (opcaoVolume.Equals("aumentar"))
        {
        smartTv.AumentarVolume();
        }else if (opcaoVolume.Equals("manter"))
        {
        Console.WriteLine("Volume atual mantido");
        smartTv.VolumeAtual();

        }else if (opcaoVolume.Equals("reduzir")){
        smartTv.DiminuirVolume();
        }
        else
        {
        Console.WriteLine("Opção inválida");
        }

    Console.WriteLine("Deseja selecionar um canal, avançar, ou voltar?");
    string selecaoCanal = Console.ReadLine();
        if (selecaoCanal.Equals("selecionar"))
        {
             smartTv.EscolherCanal(canal);
            if(canal == 1)
        {
            Console.WriteLine("  _________________________________\r\n |.--------_--_------------_--__--.|\r\n ||    /\\ |_)|_)|   /\\ | |(_ |_   ||\r\n ;;`,_/``\\|__|__|__/``\\|_| _)|__ ,:|\r\n((_(-,-----------.-.----------.-.)`)\r\n \\__ )        ,'     `.        \\ _/\r\n :  :        |_________|       :  :\r\n |-'|       ,'-.-.--.-.`.      |`-|\r\n |_.|      (( (*  )(*  )))     |._|\r\n |  |       `.-`-'--`-'.'      |  |\r\n |-'|        | ,-.-.-. |       |._|\r\n |  |        |(|-|-|-|)|       |  |\r\n :,':        |_`-'-'-'_|       ;`.;\r\n  \\  \\     ,'           `.    /._/\r\n   \\/ `._ /_______________\\_,'  /\r\n    \\  / :   ___________   : \\,'\r\n     `.| |  |           |  |,'\r\n       `.|  |           |  |\r\n         |  | SSt       |  |");
        }

        }else if (selecaoCanal.Equals("avançar")){
            smartTv.AvancarCanal();

        }else if (selecaoCanal.Equals("voltar")){
            smartTv.VoltarCanal();
        }
        else
        {
        Console.WriteLine("Opção inválida");
        }

    Console.WriteLine("Continuar assistindo?");
    continuar = Console.ReadLine();
   

} while (continuar.Equals("sim"));

Console.WriteLine("Programação encerrada, obrigado por assistir");
smartTv.desligar();
