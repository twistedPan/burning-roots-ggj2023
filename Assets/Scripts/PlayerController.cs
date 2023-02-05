// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""7ccf1d88-0d80-4522-a74e-5e572bf62573"",
            ""actions"": [
                {
                    ""name"": ""MovePlayer1"",
                    ""type"": ""Value"",
                    ""id"": ""3c1ef280-93a2-471f-9ef9-b399de3aaf42"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovePlayer2"",
                    ""type"": ""Value"",
                    ""id"": ""1e96216e-9080-4d60-a3b1-0ee432c8e522"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoinPlayer1"",
                    ""type"": ""Value"",
                    ""id"": ""d2035b38-c253-4248-a1bd-aa3ad415730a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoinPlayer2"",
                    ""type"": ""Value"",
                    ""id"": ""5def77bd-2a45-4846-97bd-85cacb2ec156"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionPlayer1"",
                    ""type"": ""Button"",
                    ""id"": ""0b5911d1-64c4-47ec-ad99-eef4613c3b3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionPlayer2"",
                    ""type"": ""Button"",
                    ""id"": ""dd527305-6c27-44a3-9d15-6187acfef462"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitGame"",
                    ""type"": ""Button"",
                    ""id"": ""a24d837d-ed8b-40f7-93a6-8fb496fec7b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17794136-150b-40e8-a788-6759f73969ed"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MovePlayer1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fab55c34-dc4c-4cb9-af85-dd392f002b40"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MovePlayer2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8debdd84-bc54-4bfb-abcf-c5a83d422f8c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JoinPlayer1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b792945b-e9e3-444e-8f71-187ce30e0ace"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JoinPlayer2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14cf519a-ac30-4ddb-9c6e-68f505005e48"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionPlayer1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f04fa0f-ccf7-412b-ad29-549dc93256e3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionPlayer2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f1d18e0-ef35-4a90-9e18-15dc02db465f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec903923-25b2-4fa0-8453-3b7cdde17b53"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""261c4af8-2fd5-4c0a-b9fb-253dac78c019"",
            ""actions"": [
                {
                    ""name"": ""MovePlayer3"",
                    ""type"": ""Value"",
                    ""id"": ""589b6e9d-11f3-4cba-b37d-d45c86547167"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovePlayer4"",
                    ""type"": ""Value"",
                    ""id"": ""71abe456-078e-4da9-871e-15f6df777e10"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoinPlayer3"",
                    ""type"": ""Value"",
                    ""id"": ""f3fd74ff-2716-421a-8ec2-33b8bff13def"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoinPlayer4"",
                    ""type"": ""Value"",
                    ""id"": ""983dc3f0-4686-4210-b2f3-a2ea911b5f6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionPlayer3"",
                    ""type"": ""Button"",
                    ""id"": ""02908522-ddcc-4b49-908c-b277ec157d11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActionPlayer4"",
                    ""type"": ""Button"",
                    ""id"": ""102249b0-7024-4a6a-b85e-b77373b16688"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitGame"",
                    ""type"": ""Button"",
                    ""id"": ""d7e05393-bfec-44c0-9805-c100f295e293"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""277386d9-180d-4643-a50e-d35eca8402ef"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionPlayer4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afd7204b-4607-47fd-b7d9-0f94c6ac3b14"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69302928-08d3-4e99-9993-52e8db58bc72"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7789790-566b-4ce9-b65f-9c10865ecee6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionPlayer3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21d6ecc9-e396-4fa3-a954-ee54552fb28a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MovePlayer3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90c469f2-5951-47fc-852a-c2d875f224f9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MovePlayer4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b72bb6e6-d44e-4d89-ae00-bd6f5b827166"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JoinPlayer3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad86c805-69af-4507-8517-2278540e8499"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""JoinPlayer4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a0ab034f-ce9f-4a58-bbef-ef43abb687c5"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""898992fc-6eb4-4828-8713-7cb266561cbf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""7b06b786-fedf-44f3-904d-ec56e7c51153"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""fd9b2a79-6613-408b-abc2-fb124fdc22a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""33ed3e65-0c6c-4c61-8ee0-8110192603f7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7e86b89f-646b-44f7-852e-59fb179add52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4529497c-b7cc-4fdd-9c30-5353988e6c9f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""db7350d0-fc7e-4f1d-8669-652cdb687c03"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3db68e41-8123-4659-bab8-c1f0033f4c58"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""82db3a71-a718-4e6e-b23f-f805503e33c6"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6af11749-6410-4477-a873-80a205f597c8"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1f6b9bd-c918-446d-a4b4-686dd7a30a97"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_MovePlayer1 = m_Player1.FindAction("MovePlayer1", throwIfNotFound: true);
        m_Player1_MovePlayer2 = m_Player1.FindAction("MovePlayer2", throwIfNotFound: true);
        m_Player1_JoinPlayer1 = m_Player1.FindAction("JoinPlayer1", throwIfNotFound: true);
        m_Player1_JoinPlayer2 = m_Player1.FindAction("JoinPlayer2", throwIfNotFound: true);
        m_Player1_ActionPlayer1 = m_Player1.FindAction("ActionPlayer1", throwIfNotFound: true);
        m_Player1_ActionPlayer2 = m_Player1.FindAction("ActionPlayer2", throwIfNotFound: true);
        m_Player1_ExitGame = m_Player1.FindAction("ExitGame", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_MovePlayer3 = m_Player2.FindAction("MovePlayer3", throwIfNotFound: true);
        m_Player2_MovePlayer4 = m_Player2.FindAction("MovePlayer4", throwIfNotFound: true);
        m_Player2_JoinPlayer3 = m_Player2.FindAction("JoinPlayer3", throwIfNotFound: true);
        m_Player2_JoinPlayer4 = m_Player2.FindAction("JoinPlayer4", throwIfNotFound: true);
        m_Player2_ActionPlayer3 = m_Player2.FindAction("ActionPlayer3", throwIfNotFound: true);
        m_Player2_ActionPlayer4 = m_Player2.FindAction("ActionPlayer4", throwIfNotFound: true);
        m_Player2_ExitGame = m_Player2.FindAction("ExitGame", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_MovePlayer1;
    private readonly InputAction m_Player1_MovePlayer2;
    private readonly InputAction m_Player1_JoinPlayer1;
    private readonly InputAction m_Player1_JoinPlayer2;
    private readonly InputAction m_Player1_ActionPlayer1;
    private readonly InputAction m_Player1_ActionPlayer2;
    private readonly InputAction m_Player1_ExitGame;
    public struct Player1Actions
    {
        private @PlayerController m_Wrapper;
        public Player1Actions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer1 => m_Wrapper.m_Player1_MovePlayer1;
        public InputAction @MovePlayer2 => m_Wrapper.m_Player1_MovePlayer2;
        public InputAction @JoinPlayer1 => m_Wrapper.m_Player1_JoinPlayer1;
        public InputAction @JoinPlayer2 => m_Wrapper.m_Player1_JoinPlayer2;
        public InputAction @ActionPlayer1 => m_Wrapper.m_Player1_ActionPlayer1;
        public InputAction @ActionPlayer2 => m_Wrapper.m_Player1_ActionPlayer2;
        public InputAction @ExitGame => m_Wrapper.m_Player1_ExitGame;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @MovePlayer1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer1;
                @MovePlayer1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer1;
                @MovePlayer1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer1;
                @MovePlayer2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer2;
                @MovePlayer2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer2;
                @MovePlayer2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovePlayer2;
                @JoinPlayer1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer1;
                @JoinPlayer1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer1;
                @JoinPlayer1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer1;
                @JoinPlayer2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer2;
                @JoinPlayer2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer2;
                @JoinPlayer2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJoinPlayer2;
                @ActionPlayer1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer1;
                @ActionPlayer1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer1;
                @ActionPlayer1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer1;
                @ActionPlayer2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer2;
                @ActionPlayer2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer2;
                @ActionPlayer2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnActionPlayer2;
                @ExitGame.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnExitGame;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayer1.started += instance.OnMovePlayer1;
                @MovePlayer1.performed += instance.OnMovePlayer1;
                @MovePlayer1.canceled += instance.OnMovePlayer1;
                @MovePlayer2.started += instance.OnMovePlayer2;
                @MovePlayer2.performed += instance.OnMovePlayer2;
                @MovePlayer2.canceled += instance.OnMovePlayer2;
                @JoinPlayer1.started += instance.OnJoinPlayer1;
                @JoinPlayer1.performed += instance.OnJoinPlayer1;
                @JoinPlayer1.canceled += instance.OnJoinPlayer1;
                @JoinPlayer2.started += instance.OnJoinPlayer2;
                @JoinPlayer2.performed += instance.OnJoinPlayer2;
                @JoinPlayer2.canceled += instance.OnJoinPlayer2;
                @ActionPlayer1.started += instance.OnActionPlayer1;
                @ActionPlayer1.performed += instance.OnActionPlayer1;
                @ActionPlayer1.canceled += instance.OnActionPlayer1;
                @ActionPlayer2.started += instance.OnActionPlayer2;
                @ActionPlayer2.performed += instance.OnActionPlayer2;
                @ActionPlayer2.canceled += instance.OnActionPlayer2;
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_MovePlayer3;
    private readonly InputAction m_Player2_MovePlayer4;
    private readonly InputAction m_Player2_JoinPlayer3;
    private readonly InputAction m_Player2_JoinPlayer4;
    private readonly InputAction m_Player2_ActionPlayer3;
    private readonly InputAction m_Player2_ActionPlayer4;
    private readonly InputAction m_Player2_ExitGame;
    public struct Player2Actions
    {
        private @PlayerController m_Wrapper;
        public Player2Actions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer3 => m_Wrapper.m_Player2_MovePlayer3;
        public InputAction @MovePlayer4 => m_Wrapper.m_Player2_MovePlayer4;
        public InputAction @JoinPlayer3 => m_Wrapper.m_Player2_JoinPlayer3;
        public InputAction @JoinPlayer4 => m_Wrapper.m_Player2_JoinPlayer4;
        public InputAction @ActionPlayer3 => m_Wrapper.m_Player2_ActionPlayer3;
        public InputAction @ActionPlayer4 => m_Wrapper.m_Player2_ActionPlayer4;
        public InputAction @ExitGame => m_Wrapper.m_Player2_ExitGame;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @MovePlayer3.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer3;
                @MovePlayer3.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer3;
                @MovePlayer3.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer3;
                @MovePlayer4.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer4;
                @MovePlayer4.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer4;
                @MovePlayer4.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMovePlayer4;
                @JoinPlayer3.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer3;
                @JoinPlayer3.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer3;
                @JoinPlayer3.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer3;
                @JoinPlayer4.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer4;
                @JoinPlayer4.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer4;
                @JoinPlayer4.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJoinPlayer4;
                @ActionPlayer3.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer3;
                @ActionPlayer3.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer3;
                @ActionPlayer3.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer3;
                @ActionPlayer4.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer4;
                @ActionPlayer4.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer4;
                @ActionPlayer4.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnActionPlayer4;
                @ExitGame.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnExitGame;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayer3.started += instance.OnMovePlayer3;
                @MovePlayer3.performed += instance.OnMovePlayer3;
                @MovePlayer3.canceled += instance.OnMovePlayer3;
                @MovePlayer4.started += instance.OnMovePlayer4;
                @MovePlayer4.performed += instance.OnMovePlayer4;
                @MovePlayer4.canceled += instance.OnMovePlayer4;
                @JoinPlayer3.started += instance.OnJoinPlayer3;
                @JoinPlayer3.performed += instance.OnJoinPlayer3;
                @JoinPlayer3.canceled += instance.OnJoinPlayer3;
                @JoinPlayer4.started += instance.OnJoinPlayer4;
                @JoinPlayer4.performed += instance.OnJoinPlayer4;
                @JoinPlayer4.canceled += instance.OnJoinPlayer4;
                @ActionPlayer3.started += instance.OnActionPlayer3;
                @ActionPlayer3.performed += instance.OnActionPlayer3;
                @ActionPlayer3.canceled += instance.OnActionPlayer3;
                @ActionPlayer4.started += instance.OnActionPlayer4;
                @ActionPlayer4.performed += instance.OnActionPlayer4;
                @ActionPlayer4.canceled += instance.OnActionPlayer4;
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @PlayerController m_Wrapper;
        public UIActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayer1Actions
    {
        void OnMovePlayer1(InputAction.CallbackContext context);
        void OnMovePlayer2(InputAction.CallbackContext context);
        void OnJoinPlayer1(InputAction.CallbackContext context);
        void OnJoinPlayer2(InputAction.CallbackContext context);
        void OnActionPlayer1(InputAction.CallbackContext context);
        void OnActionPlayer2(InputAction.CallbackContext context);
        void OnExitGame(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMovePlayer3(InputAction.CallbackContext context);
        void OnMovePlayer4(InputAction.CallbackContext context);
        void OnJoinPlayer3(InputAction.CallbackContext context);
        void OnJoinPlayer4(InputAction.CallbackContext context);
        void OnActionPlayer3(InputAction.CallbackContext context);
        void OnActionPlayer4(InputAction.CallbackContext context);
        void OnExitGame(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
}
