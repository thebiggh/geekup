def Something(load, fish, city):
    codPrice = load["cod"] * fish["cod"][city]
    octopusPrice = load["octopus"] * fish["octopus"][city]
    crabPrice = load["crab"] * fish["crab"][city]

    return codPrice + octopusPrice + crabPrice

def reduction( travel, distance, fresh):
    nottingham_reduction = ((distances["nottingham"] / 100) * nottinghamTotalFreshPrice / 100)
    nottingham_reduction += travelCosts["nottingham"]

load = {"cod": 50, "octopus": 100, "crab": 50}
fish = {"cod" : {"nottingham": 500, "glasgow" : 450, "leeds" : 600} ,
        "octopus" : {"nottingham": 0, "glasgow": 120, "leeds" : 100},
        "crab" : { "nottingham": 450, "glasgow": 0 , "leeds": 500}}

distances = {"nottingham": 800, "glasgow": 1100, "leeds": 600}

travelCosts = {"nottingham" : distances["nottingham"] * 2, 
               "glasgow": distances["glasgow"] * 2,
               "leeds": distances["leeds"] * 2}

nottinghamTotalFreshPrice = Something(load, fish, "nottingham")
glasgowTotalFreshPrice = Something(load, fish, "glasgow")
leedsTotalFreshPrice = Something(load, fish, "leeds")

print nottinghamTotalFreshPrice
print glasgowTotalFreshPrice
print leedsTotalFreshPrice

nottingham_reduction = ((distances["nottingham"] / 100) * nottinghamTotalFreshPrice / 100)
nottingham_reduction += travelCosts["nottingham"]

glasgow_reduction =  ((distances["glasgow"] / 100) * glasgowTotalFreshPrice / 100)
glasgow_reduction += travelCosts["glasgow"]

leeds_reduction =  ((distances["leeds"] / 100) * leedsTotalFreshPrice / 100)
leeds_reduction += travelCosts["leeds"]

results = []
print "Nottingham", nottinghamTotalFreshPrice - nottingham_reduction
print "Glasgow", glasgowTotalFreshPrice - glasgow_reduction
print "Leeds", leedsTotalFreshPrice - leeds_reduction
