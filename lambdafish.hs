import Test.Hspec

cities :: (Fractional a, Eq a) => ([[a]], a)
cities = [([500, 0, 450], 800), ([450, 120, 0], 1100), ([600, 100, 500], 600)]

priceAfter :: (Fractional a, Eq a) => a -> a -> a
priceAfter originalPrice 0 = originalPrice
priceAfter originalPrice distance = priceAfter (originalPrice * 0.99) (distance - 100)

costOfTravel :: (Fractional a, Eq a) => a -> a
costOfTravel = (2 *)

profit :: (Fractional a, Eq a) => [a] -> [a] -> a -> a
profit prices quantities distance = (sum $ map (\(x,y) -> y * priceAfter x distance) $ zip prices quantities) - (costOfTravel distance)

--INCOMPLETE
--maximiseProfit returns the maximum profit! D:
--maximiseProfit cities quantities distances = 

main :: IO ()
main = hspec $ do
  describe "priceAfter" $ do
    it "returns originalPrice if distance travelled is 0" $ do
      priceAfter 20 0 `shouldBe` 20

    it "returns originalPrice minus 1% after 100 kilometres" $ do
      priceAfter 100 100 `shouldBe` 99

    it "returns originalPrice minus 1% twice after 200 kilometres" $ do
      priceAfter 100 200 `shouldBe` 98.01

  describe "costOfTravel" $ do
    it "returns originalPrice if distance travelled is 0" $ do
      costOfTravel 0 `shouldBe` 0

    it "returns originalPrice minus £2 after 1 kilometre" $ do
      costOfTravel 1 `shouldBe` 2

  describe "profit" $ do
    it "returns the total profit for all my fishes" $ do
      profit [100, 500] [10, 50] 100 `shouldBe` 990 + 24750 - 200

  describe "maximiseProfit" $ do
    it "returns the city with maximum profit" $ do
      maximiseProfit cities [50, 100, 50] [800, 1100, 600] `shouldBe` 0
