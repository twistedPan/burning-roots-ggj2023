using UnityEngine;

[CreateAssetMenu(fileName = "GameValues", menuName = "ScriptableObjects/GameValues", order = 2)]
public class GameValues : ScriptableObject
{
    [field: SerializeField, Header("Game")]
    public float MaxPlayerControllerCount { get; private set; } = 2f;


    [field: SerializeField, Header("Player")]
    public float MovingSpeed { get; private set; } = 69f;
    [field: SerializeField] public float TurnSpeed { get; private set; } = .2f;
    [field: SerializeField] public float PlayerMass { get; private set; } = 50f;
    [field: SerializeField] public float PlayerCutRange { get; private set; } = 1f;


    [field: SerializeField, Header("Roots")]
    public float SomeValue { get; private set; } = 1f;


    [field: SerializeField, Header("Fire"), Tooltip("How fast is the fuel storage burned.")]
    public float FuelBurnRate { get; private set; } = 1f;
    [field: SerializeField, Tooltip("How fast is wood absorbed and added to the fuel amount.")] public float FireFuelIntakeSpeed { get; private set; } = 3f;
    [field: SerializeField, Tooltip("How much fuel gets substracted from the current fuel amount every second.")] public float FireFuelMaxDrainSpeed { get; private set; } = 1f;
    [field: SerializeField] public float FireFuelStartAmount { get; private set; } = 10f;
    [field:SerializeField] public float FireLightIntensityFactor { get; private set; } = 1f;
    [field: SerializeField, Range(0.01f, 2f)] public float FireLightRangeFactor { get; private set; } = 10f;
    [field: SerializeField, Range(0.01f,1f)] public float FireSizeFactor { get; private set; } = .5f;
    [field: SerializeField] public float FireMaxFuelLevel { get; private set; } = 800f;
    [field: SerializeField] public AnimationCurve FireFuelBurnCurve { get; private set; }
}
