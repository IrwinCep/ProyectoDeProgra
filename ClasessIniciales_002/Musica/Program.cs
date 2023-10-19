using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Artista Blur = new Artista();
            Blur.nombredelartista = "Blur";
            Blur.miembros = "Damon Albarn, Graham Coxon, " +
                "Alex Jame y Dave Rowntree";
            Blur.generosdelartista = "britpop, rock alternativo, " +
                "art rock, art pop, indie rock y pop rock";
            Blur.albums = "Leisure, Modern Life Is Rubbish, Parklife, " +
                "The Great Escape, Blur, 13, Think Tank, The Magic Whip " +
                "y The Ballad Of Darren";
            Blur.periododeactividad = 1988 - 2023;

            Album Leisure = new Album();
            Leisure.nombredelalbum = "Leisure";
            Leisure.anodepulicacion = 1991;
            Leisure.generosdelalbum = "britpop, madchester y shoegaze";
            Leisure.duraciondelalbum = 50.13f;
            Leisure.diseñodelacaratuladelalbum = "Joven mujer en piscina";

            Cancion Repetition = new Cancion();
            Repetition.nombre = "Repetition";
            Repetition.duracion = 5.25f;
            Repetition.generos = "noise pop, rock alternativo";
            Repetition.numerodepista = 4;
            Repetition.compositores = "Damon Albarn";


            Artista Asian = new Artista();
            Asian.nombredelartista = "Asian Kung-Fu Generation";
            Asian.miembros = "Masafumi Goto, Kensuke Kita, Takahiro Yamada y " +
                "Kiyoshi Ijichi";
            Asian.generosdelartista = "pop punk, indie rock y rock alternativo";
            Asian.albums = "Kimi Tsunagi Five M, Sol-Fa, Fan Club, " +
                "World World World, Surf Bungaku Kamakura, Magic Disk, " +
                "Landmark y Wonder Future";
            Asian.periododeactividad = 1996 - 2023;

            Album Kimi = new Album();
            Kimi.nombredelalbum = "Kimi Tsunagi Five M";
            Kimi.anodepulicacion = 2003;
            Kimi.generosdelalbum = "pop punk, indie rock, punk rock, " +
                "power pop, rock alternativo";
            Kimi.duraciondelalbum = 50.06f;
            Kimi.diseñodelacaratuladelalbum = "Dibujo de chica sentada de lado";

            Cancion Re = new Cancion();
            Re.nombre = "Re:Re:";
            Re.duracion = 5.32f;
            Re.generos = "indie rock, alternative rock";
            Re.numerodepista = 8;
            Re.compositores = "Masafumi Goto y Takahiro Yamada";


            Artista Linkin = new Artista();
            Linkin.nombredelartista = "Linkin park";
            Linkin.miembros = "Chester Bennington, Mike Shinoda, " +
                "Dave Farrell, Joe Hahn y Brad Delson";
            Linkin.generosdelartista = "nu metal, rock alternativo, rap metal, " +
                "metal alternativo, heavy metal, rock electronico y pop";
            Linkin.albums = "Hybrid Theory, Meteora, Minutes to Midnight, " +
                "A Thousand Suns, Living Things, The Hunting Party y One More Light";
            Linkin.periododeactividad = 1996 - 2017;

            Album Meteora = new Album();
            Meteora.nombredelalbum = "Meteora";
            Meteora.anodepulicacion = 2003;
            Meteora.generosdelalbum = "nu metal, metal alternativo, rap metal, rap rock, " +
                "rock alternativo";
            Meteora.duraciondelalbum = 36.41f;
            Meteora.diseñodelacaratuladelalbum = "Hombre graffiti el suelo";

            Cancion Heavy = new Cancion();
            Heavy.nombre = "Heavy ft. Kiiara";
            Heavy.duracion = 2.49f;
            Heavy.generos = "pop rock, electropop";
            Heavy.numerodepista = 6;
            Heavy.compositores = "Mike Shinoda y Chester Bennington";
        }
    }
}
