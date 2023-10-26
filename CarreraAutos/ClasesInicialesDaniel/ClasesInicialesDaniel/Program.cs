using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessIniciales_002
{
    class Program
    {
        //Este es el metodo main.
        // Sirve como punto de entrada
        // para el programa (inica
        //desde aqui)
        static void Main(string[] args)
        {
            //Esto es una instancia de Mochila
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vinyl";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Material = "piel";
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumLlaveros = 3;
            mochilaBeto.Precio = 179.50f;
            mochilaBeto.Tamanio = "Grande";
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaJorge = new Mochila();
            mochilaJorge.Material = "Tela";
            mochilaJorge.Disenio = "Fornite";
            mochilaJorge.NumDeBolsas = 4;
            mochilaJorge.NumLlaveros = 2;
            mochilaJorge.Precio = 310.50f;
            mochilaJorge.Tamanio = "Grande";
            mochilaJorge.color = new Color();
            mochilaJorge.color.Rojo = 34;
            mochilaJorge.color.Verde = 47;
            mochilaJorge.color.Azul = 128;

            Smartphone GalaxyA = new Smartphone();
            GalaxyA.NetworkTech = "GSM / HSPA / LTE";

            GalaxyA.LaunchAnnounced = 2021 / 02 / 25;
            GalaxyA.LaunchStatus = "Available";

            GalaxyA.BodyDimensionsHeight = 158.90f;
            GalaxyA.BodyDimensionsBroad = 73.60f;
            GalaxyA.BodyDimensionsThickness = 8.40f;
            GalaxyA.BodyWeight = 184;
            GalaxyA.BodyBuild = "Glass front " +
                "(Gorilla Glas Five), plastic frame, plastic back";
            GalaxyA.BodySIM = "Single SIM (Nano-SIM) or Dual SIM" +
                "(Nano-SIM, dual stand-by)";

            GalaxyA.DisplayType = "Super AMOLED";
            GalaxyA.DisplayTypeHz = 90;
            GalaxyA.DisplayTypeNits = 800;
            GalaxyA.DisplaySize = 98.90f;
            GalaxyA.DisplayResolutionHeight = 1080;
            GalaxyA.DisplayResolutionBroad = 2400;
            GalaxyA.DisplayProtection = "Corning Gorilla Glass Five";

            GalaxyA.PlataformOSAndroid = 11;
            GalaxyA.PlataformOsUpagradeAndroid = 13;
            GalaxyA.PlataformChipset = "Mediatek";
            GalaxyA.PlataformCPU = "Octa-core";
            GalaxyA.PlataformGPU = "Mali-G52 MC2";

            GalaxyA.MemoryCardslot = "microSDXC (dedicated slot)";
            GalaxyA.MemoryInternalGB = 64 / 128 / 128 / 128;
            GalaxyA.MemoryInternalRAMGB = 4 / 4 / 6 / 8;
            GalaxyA.MaincameraQuadMP = 64 / 8 / 5 / 5;
            GalaxyA.MaincameraQuadf = 1.80f / 2.20f / 2.40f / 2.40f;
            GalaxyA.MaincameraQuad = "(wide) / (ultrawide) / (macro) / (depth)";
            GalaxyA.MaincameraFeatures = "LED flash, panorama, HDR";
            GalaxyA.MaincameraVideop = 1080;
            GalaxyA.MaincameraVideofps = 30;

            GalaxyA.SelfiecameraSingleMP = 20;
            GalaxyA.SelfiecameraSinglef = 2.20f;
            GalaxyA.SelfiecameraSingle = "(wide)";
            GalaxyA.SelfiecameraVideop = 1080;
            GalaxyA.SelfiecameraVideofps = 30;

            GalaxyA.SoundLoudspeaker = "Yes";
            GalaxyA.Soundjack = "Yes";

            GalaxyA.CommsWlanWifi = 5.00f;
            GalaxyA.CommsWlan = "a/b/g/n/ac, dual-band, Wi-fi Direct";
            GalaxyA.CommsBluetooth = 5.00f;
            GalaxyA.CommsPositioning = "GPS, GLONASS, BDS, GALILEO";
            GalaxyA.CommsNfc = "Yes (market/region dependent)";
            GalaxyA.CommsRadio = "FM radio, RDS, recording";
            GalaxyA.CommsUsb = "USB Type-C";

            GalaxyA.FeaturesSensors = "Fingerprint (under display, optical)" +
                ", accelerometer, gyro, compass";

            GalaxyA.BatteryTypemAh = 5000;
            GalaxyA.BatteryType = "Li-lon, non-removable";
            GalaxyA.BatteryChargingW = 15;

            GalaxyA.MiscColors = "Awesome Black, Awesome White, " +
                "Awesome Blue, Awesome Violet";
            GalaxyA.MiscModels = "SM-F, SM-F/DS, SM-M, SM-N";
            GalaxyA.MiscSarEuheadkg = 0.45f;
            GalaxyA.MiscSarEubodykg = 1.30f;
            GalaxyA.MiscPriceDollars = 226.99f;
            GalaxyA.MiscPriceEuro = 279.00f;
            GalaxyA.MiscPricePound = 234.99f;

            GalaxyA.TestsPerformanceAnTuTu = 286666;
            GalaxyA.TestsPerformanceAnTuTuversion = 8;
            GalaxyA.TestsPerformanceGeekBench = 1277;
            GalaxyA.TestsPerformanceGeekBenchversion = 5;
            GalaxyA.TestsPerformanceGfxBench = 8;
            GalaxyA.TestsPerformanceGfxBenchV = "onscreen";
            GalaxyA.TestsDisplay = "Contrast ratio:  Infinite (nominal)";
            GalaxyA.TestsCamera = "Photo / Video";
            GalaxyA.TestsLoudspeakerLufs = -30.30f;
            GalaxyA.TestsBatterylifeH = 119;
        }
    }
}

        
   

