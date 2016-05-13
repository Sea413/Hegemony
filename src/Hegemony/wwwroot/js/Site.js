
var TotalPoints = function (armyV) {
    this.armyV = armyV;
    this.captialV = captialV;
    this.resourcesV = resourcesV;
    this.populationV = populationV;
    this.technologyV = technologyV;
    this.happinessV = happinessV;
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
    }
    $("#armyV").html(this.armyV);
    $("#aSizeOutput").val(this.armyV);
}
$(document).ready(function () {
    var newTotalPoints = new TotalPoints(parseInt($("#aSizeOutput").val()));
    //var newTotalPoints = new TotalPoints(parseInt($("#aSizeOutput").val()), parseInt($("#capitalOutput").val()),parseInt($("#populationOutput").val()),parseInt($("#happinessOutput").val()),parseInt($("#technologyOutput").val()));
    $('.GovernmentId1').change(function () {
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
            console.log("firing");
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
            $('.GovernmentId1').change(function () {
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
                console.log("firing");
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
        });
    });
