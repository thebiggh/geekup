require 'spec_helper'

    class Market
      attr_reader :name, :dist, :prices

      def initialize(name, dist, prices)
        @name = name
        @dist = dist.to_f
        @prices = prices
      end

      def quote(cargo)
        result = 0

        cargo.each do |product_name, product_qty|
          result += prices.fetch(product_name, 0) * product_qty
        end

        return result if result == 0

        result -= degrade_cost(result)
        result -= travel_cost
        result
      end

      def travel_cost
        (@dist * 2)
      end

      def degrade_cost(price)
        price * (@dist / 10000)
      end
    end

    class MarketChooser
      def initialize(markets)
        @markets = markets
      end

      def best_market(cargo)
        result = @markets.map do |market|
          { :market => market, :quote => market.quote(cargo) }
        end

        result.sort_by { |quote| quote[:quote]}.last[:market]
      end
    end

describe 'challenge 2' do
  it 'works' do
    nottingham_market = Market.new('Nottingham', 800, { :cod => 500,
                                    :octopus => 0,
                                    :crab => 450  })

    glasgow_market = Market.new('Glasgow', 1100, { :cod => 450,
                                    :octopus => 120,
                                    :crab => 0  })

    leeds_market = Market.new('Leeds', 600, { :cod => 600,
                                    :octopus => 100,
                                    :crab => 500  })

    markets = [nottingham_market, glasgow_market, leeds_market]

    cargo = { :cod => 50, :octopus => 100, :crab => 50 }

    chooser = MarketChooser.new(markets)

    chooser.best_market(cargo).should == leeds_market
  end
end
