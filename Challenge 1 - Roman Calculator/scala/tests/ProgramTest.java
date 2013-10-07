import org.junit.Test;

import static org.junit.Assert.*;
import static org.junit.Assert.assertEquals;


public class ProgramTest {

    @Test
    public void TheBestPlaceToSell50KGOfCodIsLeeds() {
        FishyCalc fishCalc = new FishyCalc();

        String plaice = fishCalc.getBestPlaice("cod", 50);

        assertEquals("Leeds", plaice);
    }

//    @Test
//    public void TheBestPlaceToSell100KgOfOctoIsGlasgow() {
//        FishyCalc fishCalc = new FishyCalc();
//
//        String plaice = fishCalc.getBestPlaice("cod", 50);
//
//        assertEquals("Leeds", plaice);
//    }

    @Test
    public void TheCostOfPetrolFor100KmIs200Pounds() {
        FishyCalc fishCalc = new FishyCalc();

        int cost = fishCalc.calculateFuelCost(100);
        assertEquals(cost, 200);
    }

    @Test
    public void _100PoundsWorthOfFishDecreasesTo99PoundsAfter100Km() {
        FishyCalc fishCalc = new FishyCalc();

        double cost = fishCalc.calculateDevaluation(100.0f, 100f);
        assertEquals(cost, 99.0f, 0.01);
    }

    @Test
    public void _200PoundsWorthOfFishDecreasesTo198PoundsAfter100Km() {
        FishyCalc fishCalc = new FishyCalc();

        double cost = fishCalc.calculateDevaluation(200f, 100f);
        assertEquals(cost, 198, 0.01);
    }

    @Test
    public void _200PoundsWorthOfFishDecreasesTo196PoundsAfter200Km() {
        FishyCalc fishCalc = new FishyCalc();

        double cost = fishCalc.calculateDevaluation(200f, 200f);
        assertEquals(cost, 196, 0.01);
    }

    @Test
    public void TheBestPriceFor100kgOctopusIsGlasgow(){
        FishyCalc fishCalc = new FishyCalc();

        String location = fishCalc.getBestPlaice("octupus", 100);
        assertEquals(location, "Glasgow");
    }

    @Test
    public void TheBestPriceFor50kgCodIsLeeds(){
        FishyCalc fishCalc = new FishyCalc();

        String location = fishCalc.getBestPlaice("cod", 50);
        assertEquals(location, "Leeds");
    }
}
