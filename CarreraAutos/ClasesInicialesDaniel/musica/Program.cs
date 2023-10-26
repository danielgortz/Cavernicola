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
            Artista Mora = new Artista();
            Mora.nombredelartista = "Mora";
            Mora.miembros ="Mora";
            Mora.generosdelartista ="regueton urbano";
            Mora.albums ="Paraíso ,último día de clases ";
            Mora.periododeactividad = 2014 - 2023;

            Album Paraíso = new Album();
            Paraíso.nombredelalbum = "Paraíso ";
            Paraíso.anodepulicacion = 2022;
            Paraíso.generosdelalbum = "regueton urbano";
            Paraíso.duraciondelalbum = 43.16f;
            Paraíso.diseñodelacaratuladelalbum = "sombra con colores brillantes";

            Cancion Apa = new Cancion();
            Apa.nombre = " Apa";
            Apa.duracion = 3.50f;
            Apa.generos = "regueton";
            Apa.numerodepista = 4;
            Apa.compositores = "Quevedo ";


            Artista kaarl = new Artista();
            kaarl.nombredelartista = "Kevin kaarl ";
            kaarl.miembros = "Kevin kaarl ,Bryan kaarl";
            kaarl.generosdelartista = "Indy";
            kaarl.albums = "San lucas,Vámonos a Marte,Paris Texas ";
            kaarl.periododeactividad = 2017 - 2023;

            Album Sanlucas = new Album();
            Sanlucas.nombredelalbum = "San Lucas";
            Sanlucas.anodepulicacion = 2021;
            Sanlucas.generosdelalbum = "indy";
            Sanlucas.duraciondelalbum = 50.06f;
            Sanlucas.diseñodelacaratuladelalbum = "cartel de ciudad con una pareja ";

            Cancion Vete = new Cancion();
            Vete.nombre = "Vete";
            Vete.duracion = 2.32f;
            Vete.generos = "indie ";
            Vete.numerodepista = 2;
            Vete.compositores = "Kevin kaarl ";


            Artista Nata = new Artista();
            Nata.nombredelartista = "Natanael Cano ";
            Nata.miembros = "Natanael cano";
            Nata.generosdelartista = "Corridos tumbados";
            Nata.albums = "Natakong ,Natamontana";
            Nata.periododeactividad = 2017 - 2023;

            Album Kong = new Album();
            Kong.nombredelalbum = "Natakong";
            Kong.anodepulicacion = 2021;
            Kong.generosdelalbum = "Corridos ,electrónica ";
            Kong.duraciondelalbum = 56.41f;
            Kong.diseñodelacaratuladelalbum = "nata en un edificio viendo la ciudad";

            Cancion Angel = new Cancion();
            Angel.nombre = "Mi bello ángel ";
            Angel.duracion = 3.49f;
            Angel.generos = "corridos tumbados";
            Angel.numerodepista = 6;
            Angel.compositores = "Natanael Cano";
        }
    }
}
