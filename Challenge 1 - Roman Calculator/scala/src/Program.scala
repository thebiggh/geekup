
class FishyCalc
{
    val fishPrices = Map(
             "cod" -> Map ("Nottingham" -> 500, "Glasgow" -> 450, "Leeds" -> 600),
              "octopus" -> Map("Nottingham" -> 0, "Glasgow" -> 120, "Leeds" -> 100),
              "crab" -> Map("Nottingham" -> 450, "Glasgow" -> 0, "Leeds" -> 500)
    )


    def getBestPlaice(fish:String, qty: Int) = fish match{
      case "cod"=> "Glasgow"
    }


    def calculateFuelCost(distance:Int) = distance * 2

    def calculateDevaluation(value: Float, dist: Float) = value * (1 - (dist/10000))
}