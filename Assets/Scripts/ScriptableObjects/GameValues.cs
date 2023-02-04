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


    [field: SerializeField, Header("Fire")]
    public float FuelBurnRate { get; private set; } = 1f;
    [field: SerializeField] public float FuelFillSpeed { get; private set; } = 3f;
    [field: SerializeField] public float FireFuelDrain { get; private set; } = 1f;
    [field: SerializeField] public float FireFuelStartAmount { get; private set; } = 10f;
    [field:SerializeField] public float FireLightIntensityFactor { get; private set; } = 1f;
    [field: SerializeField] public float FireLightRangeFactor { get; private set; } = 10f;
    [field: SerializeField, Range(0.01f,1f)] public float FireSizeFactor { get; private set; } = .5f;
}
