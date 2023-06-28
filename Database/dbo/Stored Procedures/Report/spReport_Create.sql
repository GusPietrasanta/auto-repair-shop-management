﻿CREATE PROCEDURE [dbo].[spReport_Create]
	@TimeStarted datetime2,
	@TimeFinished datetime2,
	@VehicleID INT,
	@MechanicID INT,
	@AppointmentID INT,
	@Date DATETIME2,
	@Odometer INT,
	@RoadTestComments VARCHAR(MAX),
	@GeneralComments VARCHAR(MAX),
	@StoredFaultCodes VARCHAR(MAX),
	@AirConditioning VARCHAR(30),
	@Lights VARCHAR(30),
	@LightsComments VARCHAR(MAX),
	@FrontWipers VARCHAR(30),
	@RearWiper VARCHAR(30),
	@Battery VARCHAR(30),
	@BatteryComments VARCHAR(MAX),
	@RHFTyre VARCHAR(30),
	@LHFTyre VARCHAR(30),
	@RHRTyre VARCHAR(30),
	@LHRTyre VARCHAR(30),
	@TyresComments VARCHAR(MAX),
	@NeedsAlignment BIT,
	@AirFilter VARCHAR(30),
	@CabinFilter VARCHAR(30),
	@DriveBelts VARCHAR(30),
	@TimingBelt VARCHAR(30),
	@Radiator VARCHAR(30),
	@Hoses VARCHAR(30),
	@HosesComments VARCHAR(MAX),
	@EngineOil VARCHAR(30),
	@Coolant VARCHAR(30),
	@BrakeFluid VARCHAR(30),
	@PowerSteeringFluid VARCHAR(30),
	@TransmissionFluid VARCHAR(30),
	@WindscreenWasherFluid VARCHAR(30),
	@FluidsComments VARCHAR(MAX),
	@SparkPlugs VARCHAR(30),
	@FuelFilter VARCHAR(30),
	@FrontSuspension VARCHAR(30),
	@FrontSuspensionComments VARCHAR(MAX),
	@RearSuspension VARCHAR(30),
	@RearSuspensionComments VARCHAR(MAX),
	@FrontBrakes VARCHAR(30),
	@FrontBrakesComments VARCHAR(MAX),
	@RearBrakes VARCHAR(30),
	@RearBrakesComments VARCHAR(MAX),
	@Exhaust VARCHAR(30),
	@ExhaustComments VARCHAR(MAX),
	@Drivetrain VARCHAR(30),
	@DrivetrainComments VARCHAR(MAX),
	@OilLeaks VARCHAR(30),
	@OilLeaksComments VARCHAR(MAX),
	@CoolantLeaks VARCHAR(30),
	@CoolantLeaksComments VARCHAR(MAX),
	@OtherLeaksComments VARCHAR(MAX),
	@Other VARCHAR(MAX),
	@OtherInspectionComments VARCHAR(MAX)
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.Report (TimeStarted, TimeFinished, VehicleID, MechanicID, AppointmentID, Date, Odometer, RoadTestComments,
                            GeneralComments, StoredFaultCodes, AirConditioning, Lights, LightsComments, FrontWipers,
                            RearWiper, Battery, BatteryComments, RHFTyre, LHFTyre, RHRTyre, LHRTyre, TyresComments,
                            NeedsAlignment, AirFilter, CabinFilter, DriveBelts, TimingBelt, Radiator, Hoses, HosesComments,
                            EngineOil, Coolant, BrakeFluid, PowerSteeringFluid, TransmissionFluid, WindscreenWasherFluid,
                            FluidsComments, SparkPlugs, FuelFilter, FrontSuspension, FrontSuspensionComments, RearSuspension,
                            RearSuspensionComments, FrontBrakes, FrontBrakesComments, RearBrakes, RearBrakesComments, Exhaust,
                            ExhaustComments, Drivetrain, DrivetrainComments, OilLeaks, OilLeaksComments, CoolantLeaks,
                            CoolantLeaksComments, OtherLeaksComments, Other, OtherInspectionComments) 
	VALUES (@TimeStarted, @TimeFinished, @VehicleID, @MechanicID, @AppointmentID, @Date, @Odometer, @RoadTestComments, @GeneralComments,
            @StoredFaultCodes, @AirConditioning, @Lights, @LightsComments, @FrontWipers, @RearWiper, @Battery,
            @BatteryComments, @RHFTyre, @LHFTyre, @RHRTyre, @LHRTyre, @TyresComments, @NeedsAlignment, @AirFilter,
            @CabinFilter, @DriveBelts, @TimingBelt, @Radiator, @Hoses, @HosesComments, @EngineOil, @Coolant, @BrakeFluid,
            @PowerSteeringFluid, @TransmissionFluid, @WindscreenWasherFluid, @FluidsComments, @SparkPlugs, @FuelFilter,
            @FrontSuspension, @FrontSuspensionComments, @RearSuspension, @RearSuspensionComments, @FrontBrakes,
            @FrontBrakesComments, @RearBrakes, @RearBrakesComments, @Exhaust, @ExhaustComments, @Drivetrain,
            @DrivetrainComments, @OilLeaks, @OilLeaksComments, @CoolantLeaks, @CoolantLeaksComments, @OtherLeaksComments,
            @Other, @OtherInspectionComments);

END
