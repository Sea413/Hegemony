
var TotalPoints = function (armyV, capitalV, resourcesV, populationV, technologyV, happinessV) {
    this.armyV = 1000;
    this.capitalV = 1000;
    this.resourcesV = 1000;
    this.populationV = 1000;
    this.technologyV = 1000;
    this.happinessV = 1000;
}
TotalPoints.prototype.armyFunction = function () {
    var armystuff = parseInt($("#ArmyId").val());
   

    if (armystuff === 2) {
        this.armyV = (this.populationV *.25)
        $("#aSizeOutput").html(this.armyV);
        
    } else if (armystuff === 8) {
        this.armyV = 0;
        $("#aSizeOutput").html(this.armyV);
        
        
    } else {
        this.armyV = 1000;
        $("#aSizeOutput").html(this.armyV);
        $("#aSizeOutput").val(this.armyV);
    }
    $("#armyV").html(this.armyV);
  
    
}

TotalPoints.prototype.economicFunction = function () {
    var economicVar = parseInt($("#EconomyId").val());
    $("#aSizeOutput").val(this.armyV);
    if (economicVar === 2) {
        this.capitalV = this.populationV;
        $("#capitalOutput").html(this.capitalV);
    } else {
        this.capitalV = 1000;
        $("#capitalOutput").html(this.capitalV);
    }
}
TotalPoints.prototype.technologyFunction = function () {
    var economicVar = parseInt($("#EconomyId").val());
    var technologyVar = parseInt($("#TechnologyId").val());
    var geographyVar = parseInt($("#GeographyId").val());
    if (technologyVar === 1) {
        this.technologyV = 0;
        this.capitalV = this.populationV;
        $("#technologyOutput").html(this.technologyV);
    }
    else if (technologyVar === 2) {
        this.technologyV = 1000;
        this.populationV = 1000;
        this.populationV = (this.populationV * .1)
        $("#technologyOutput").html(this.technologyV);
        $("#populationOutput").html(this.populationV);
        $("#capitalOutput").html(this.capitalV);
    } else {
        this.technologyV = 1000;
        this.populationV = 1000;
        $("#technologyOutput").html(this.technologyV);
        $("#populationOutput").html(this.populationV);
        $("#capitalOutput").html(this.capitalV);
    }
}
TotalPoints.prototype.geographyFunction = function () {
    $("#aSizeOutput").val(this.armyV);
        var economicVar = parseInt($("#EconomyId").val());
        var geographyVar = parseInt($("#GeographyId").val());
        var technologyVar = parseInt($("#TechnologyId").val());
        this.happinessV = 1000;
        if (geographyVar === 1) {
            this.populationV = 1000;
            this.happinessV = 1000;
            this.populationV = (this.populationV * .75);

            $("#populationOutput").html(this.populationV);
            $("#happinessOutput").html(this.happinessV);

        } else if (geographyVar === 6) {
            this.happinessV = 1000;
            this.populationV = 1000;
            this.happinessV = (this.happinessV * 2)
            $("#happinessOutput").html(this.happinessV);
        }
        else {
            this.happinessV = 1000;
            $("#happinessOutput").html(this.happinessV);
        }
    }
TotalPoints.prototype.combinedFunction = function () {
        var economicVar = parseInt($("#EconomyId").val());
        var geographyVar = parseInt($("#GeographyId").val());
        var technologyVar = parseInt($("#TechnologyId").val());
        var geographyVar = parseInt($("#GeographyId").val());
        $("#ArmyValue").val(this.armyV);
        $("#PopulationValue").val(this.populationV);
        $("#CapitalValue").val(this.capitalV);
        $("#ResourceValue").val(this.resourcesV);
        $("#HappinessValue").val(this.happinessV);
        $("#TechnologyValue").val(this.technologyV);
        

        if ((geographyVar === 1) && (technologyVar === 2) && (economicVar !==2)) {
            this.populationV = 75;


            $("#populationOutput").html(this.populationV);

            $("#aSizeOutput").html(this.armyV);
            console.log("aSizeOutput")
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);
        }
        else if ((geographyVar == 1) && (technologyVar === 2) && (economicVar === 2)) {
            this.populationV = 75;
            this.capitalV = this.populationV;


            $("#populationOutput").html(this.populationV);

            $("#aSizeOutput").html(this.armyV);
            this.capitalV = this.populationV;
            $("#populationOutput").html(this.populationV);
            $("#aSizeOutput").html(this.armyV);
            $("#capitalOutput").html(this.capitalV);
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);
        }

        else if ((geographyVar !== 1) && (technologyVar === 2)) {
            this.populationV = 100
            $("#populationOutput").html(this.populationV);
            $("#aSizeOutput").html(this.armyV);
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);
        } else if ((geographyVar === 1) && (technologyVar !== 2)) {
            this.populationV = 750;
            $("#populationOutput").html(this.populationV);
            $("#aSizeOutput").html(this.armyV);
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);
           
        } else if ((geographyVar === 1) && (technologyVar === 2)) {
            this.populationV = 75;
            $("#populationOutput").html(this.populationV);
            $("#aSizeOutput").html(this.armyV);
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);

        } else {
            this.populationV = 1000;
            $("#aSizeOutput").html(this.armyV);
            
            $("#populationOutput").html(this.populationV);
            $("#ArmyValue").val(this.armyV);
            $("#PopulationValue").val(this.populationV);
            $("#CapitalValue").val(this.capitalV);
            $("#ResourceValue").val(this.resourcesV);
            $("#HappinessValue").val(this.happinessV);
            $("#TechnologyValue").val(this.technologyV);
           
        }
    }
    $(document).ready(function () {
        var newTotalPoints = new TotalPoints(parseInt($("#aSizeOutput").val()), parseInt($("#capitalOutput").val()), parseInt($("#populationOutput").val()), parseInt($("#happinessOutput").val()), parseInt($("#technologyOutput").val()));
        $('.GovernmentId1').change(function () {
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            $.ajax({
                url: '/Game/newGovernment/' + $('#GovernmentId').val(),
                type: 'GET',
                data: $(this).serialize(),
                dataType: 'json',
                success: function (GovernmentResult) {
                    var result1 = GovernmentResult.Description
                    $('.GovernmentResults').html(result1);
                }
            });
        });
        $('.ArmyId1').change(function () {
            newTotalPoints.armyFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            $.ajax({
                url: '/Game/newArmy/' + $('#ArmyId').val(),
                type: 'GET',
                data: $(this).serialize(),
                dataType: 'json',
                success: function (ArmyResult) {
                    var result2 = ArmyResult.Description
                    $('.ArmyResults').html(result2);
                }
            });
        });
        $('.EconomyId1').change(function () {
            newTotalPoints.armyFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            $.ajax({
                url: '/Game/newEconomy/' + $('#EconomyId').val(),
                type: 'GET',
                data: $(this).serialize(),
                dataType: 'json',
                success: function (EconomyResult) {
                    var result3 = EconomyResult.Description
                    $('.EconomyResults').html(result3);
                }
            });
        });
        $('.TechnologyId1').change(function () {
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            $.ajax({
                url: '/Game/newTechnology/' + $('#TechnologyId').val(),
                type: 'GET',
                data: $(this).serialize(),
                dataType: 'json',
                success: function (TechnologyResult) {
                    var result4 = TechnologyResult.Description
                    $('.TechnologyResults').html(result4);
                }
            });
        });
        $('.GeographyId1').change(function () {
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            newTotalPoints.technologyFunction();
            newTotalPoints.armyFunction();
            newTotalPoints.geographyFunction();
            newTotalPoints.economicFunction();
            newTotalPoints.combinedFunction();
            $.ajax({
                url: '/Game/newGeography/' + $('#GeographyId').val(),
                type: 'GET',
                data: $(this).serialize(),
                dataType: 'json',
                success: function (GeographyResult) {
                    var result5 = GeographyResult.Description
                    $('.GeographyResults').html(result5);
                }
            });
        });
        $('#submitArray').submit(function () {
            var dataObject = {
                ArmyValue: $("#aSizeOutput").val(),
                PopulationValue: $("aSizeOutput").val()

            }
            $.ajax({
                url: '/Game/newArmySubmit/',
                type: 'GET',
                data: dataObject,
                dataType: 'json',
                success: function () {
                    
                }
            });
        });
    });