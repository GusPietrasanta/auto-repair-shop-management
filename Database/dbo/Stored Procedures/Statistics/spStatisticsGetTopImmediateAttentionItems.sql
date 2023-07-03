CREATE PROCEDURE [dbo].[spStatisticsGetTopImmediateAttentionItems]
AS
BEGIN

	SELECT TOP 7
    Item,
    COUNT(*) AS Occurrences
    FROM (
        SELECT
            [AirConditioning], [Lights], [FrontWipers], [RearWiper], [Battery],
            [RHFTyre], [LHFTyre], [RHRTyre], [LHRTyre],
            [AirFilter], [CabinFilter], [DriveBelts], [TimingBelt], [Radiator], [Hoses], 
            [EngineOil], [Coolant], [BrakeFluid], [PowerSteeringFluid],
            [TransmissionFluid], [WindscreenWasherFluid], [SparkPlugs],
            [FuelFilter], [FrontSuspension], [RearSuspension], [FrontBrakes], [RearBrakes], [Exhaust], [Drivetrain],
            [OilLeaks], [CoolantLeaks]
        FROM [dbo].[Report]
    ) AS p
    UNPIVOT (
        Value FOR Item IN (
            [AirConditioning], [Lights], [FrontWipers], [RearWiper], [Battery],
            [RHFTyre], [LHFTyre], [RHRTyre], [LHRTyre],
            [AirFilter], [CabinFilter], [DriveBelts], [TimingBelt], [Radiator], [Hoses], 
            [EngineOil], [Coolant], [BrakeFluid], [PowerSteeringFluid],
            [TransmissionFluid], [WindscreenWasherFluid], [SparkPlugs],
            [FuelFilter], [FrontSuspension], [RearSuspension], [FrontBrakes], [RearBrakes], [Exhaust], [Drivetrain],
            [OilLeaks], [CoolantLeaks]
        )
    ) AS unpvt
    WHERE Value = 'Requires immediate attention'
    GROUP BY Item;

END
RETURN 0
