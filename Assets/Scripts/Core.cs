using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct Health
{
    public int head, neck, torso, rArm, lArm, rLeg, lLeg;

    public int rEye, lEye, rEar, lEar, nose, mouth;

    public int spine, heart, stomach, liver, rLung, lLung, rKidney, lKidney;

    public void Default()
    {
        head = 32;
        neck = 16;
        torso = 64;
        rEye = 4;
        lEye = 4;
        rEar = 4;
        lEar = 4;
        nose = 4;
        mouth = 8;
        spine = 12;
        heart = 8;
        stomach = 16;
        liver = 12;
        rLung = 12;
        lLung = 12;
        rKidney = 8;
        lKidney = 8;
        rArm = 32;
        lArm = 32;
        rLeg = 32;
        lLeg = 32;
    }
}

struct Skills
{
    public float melee, throwing, shooting, dodge;
    public float magic, crafting, smithing, cooking;
    public float hunting, gathering, farming, mining;

    public void Default()
    {
        melee = 1;
        throwing = 1;
        shooting = 1;
        dodge = 1;

        magic = 1;
        crafting = 1;
        smithing = 1;
        cooking = 1;

        hunting = 1;
        gathering = 1;
        farming = 1;
        mining = 1;
    }
}

struct Item
{
    public string name;
    public int category, inStack, durability, grade, maxStack, weight, volume, twoHanded, slot;
    public void Default()
    {
        name = "Null";
        category = 0;

        maxStack = 0;
        weight = 0;
        volume = 0;
        twoHanded = 0;
        slot = 0;

        inStack = 0;
        durability = 0;
        grade = 0;
    }
}

class Equipment
{
    public Item rightHand, leftHand, head, underClothes, torso, outerwear, pants, belt, gloves, shoes;
    public void check()
    {
        if (leftHand.category != 6 || leftHand.category != 0 || rightHand.twoHanded == 1)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            leftHand.Default();
        }
        if (rightHand.category != 6 || rightHand.category != 0 || leftHand.twoHanded == 1)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            rightHand.Default();
        }
        if (head.slot != 1 || head.category != 7 || head.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            head.Default();
        }
        if (underClothes.slot != 2 || underClothes.category != 7 || underClothes.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            underClothes.Default();
        }
        if (torso.slot != 3 || torso.category != 7 || torso.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            torso.Default();
        }
        if (outerwear.slot != 4 || outerwear.category != 7 || outerwear.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            outerwear.Default();
        }
        if (pants.slot != 5 || pants.category != 7 || pants.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            pants.Default();
        }
        if (belt.slot != 6 || belt.category != 7 || belt.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            belt.Default();
        }
        if (gloves.slot != 7 || gloves.category != 7 || gloves.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            gloves.Default();
        }
        if (shoes.slot != 8 || shoes.category != 7 || shoes.category != 0)
        {
            //Необходимо создать этот неправильный предмет под пешкой!
            shoes.Default();
        }
    }
}

class Pawn
{
    public string name;
    public string secondName;

    public int species; //{Human, Elf, Dwarf, Goblin, Ogre};
    public int gender; //{None, Man, Women};
    public int status; //{Normal, Advanced, Hurt, Bleeding, CloseToDeath, Death, Destroyed};

    Health health = new Health();

    public int stamina;
    public int sleepiness;
    public int satiety;
    public int fleshiness;
    public int battleExpHuman;
    public int battleExpMonster;

    Skills skills = new Skills();
    Equipment equipment = new Equipment();
    //Morale? pfff
}

public class Core : MonoBehaviour
{
    int scrollArea;
    public Camera cam;
    float camScale;
    Vector3 camPos;
    public int[,,,,,,] level;
    int layerNow;
    public Sprite l0t0;
    public Sprite l0t1;
    public Sprite l0t2;
    public Sprite l0t3;
    public Sprite l0t4;
    public Sprite l0t5;
    public Sprite l1t0;
    public Sprite l1t1;
    public Sprite l1t2;
    public Sprite l1t3;
    public Sprite l1t4;
    public Sprite l1t5;
    public Sprite l1t6;
    public Sprite l1t7;
    public Sprite l1t8;
    public Sprite l1t9;
    public Sprite l1t10;
    public Sprite l1t11;
    public Sprite l1t12;
    public Sprite l1t13;
    public Sprite l1t14;
    public Sprite l1t15;
    public Sprite l1t16;
    public Sprite l2t1;
    public Sprite l2t2;
    public Sprite l2t3;
    public Sprite l2t4;
    public Sprite l2t5;
    public Sprite l2t6;
    int layer;
    int xRegion;
    int yRegion;
    int xChunk;
    int yChunk;
    int x;
    int y;
    int xAbs;
    int yAbs;
    int mapSideSizeInRegions;
    int mapSideSizeInChunks;
    int mapSideSizeInTiles;
    int mapSizeInRegions;
    int mapSizeInChunks;
    int mapSizeInTiles;
    int regionSideSizeInChunks;
    int regionSideSizeInTiles;
    int regionSizeInChunks;
    int regionSizeInTiles;
    int chunkSideSizeInTiles;
    int chunkSizeInTiles;
    int[] chance;
    int[] counter;
    int chanceMod;
    int chanceMat;
    int temp;
    System.Random Rand = new System.Random();
    bool genDone;

    // Use this for initialization
    void Start()
    {
        mapSideSizeInTiles = 256;
        chunkSideSizeInTiles = 16;
        regionSideSizeInChunks = 4;
        mapSizeInTiles = mapSideSizeInTiles ^ 2;
        chunkSizeInTiles = chunkSideSizeInTiles ^ 2;
        regionSizeInChunks = regionSideSizeInChunks ^ 2;
        regionSideSizeInTiles = regionSideSizeInChunks * chunkSideSizeInTiles;
        regionSizeInTiles = regionSideSizeInTiles ^ 2;
        mapSizeInChunks = mapSideSizeInTiles / chunkSizeInTiles;
        mapSizeInRegions = chunkSizeInTiles / regionSizeInChunks;
        mapSideSizeInRegions = mapSideSizeInTiles / regionSideSizeInTiles;
        mapSideSizeInChunks = mapSideSizeInTiles / chunkSideSizeInTiles;
        chance = new int[6] { 100, 100, 100, 100, 100, 100 };
        counter = new int[6] { 100, 100, 100, 100, 100, 100 };
        scrollArea = 0;
        GenerateLevel();
        ShowLevel();
    }

    // Update is called once per frame
    void Update()
    {
        //Camera Scaling
        if (camScale < 20.0f)
            camScale += -(Input.GetAxis("Mouse ScrollWheel")) * 2.0f;
        else camScale = 20.0f;
        if (camScale > 1.0f)
            camScale -= (Input.GetAxis("Mouse ScrollWheel")) * 2.0f;
        else camScale = 1.0f;
        cam.orthographicSize = camScale;
        
        //Camera moving
        if (Input.GetKey(KeyCode.W) || (Input.mousePosition.y > Screen.height - scrollArea && Input.mousePosition.y < Screen.height))
            camPos += Vector3.up * 0.25f;
        if (Input.GetKey(KeyCode.A) || (Input.mousePosition.x < scrollArea && Input.mousePosition.x > 0))
            camPos += Vector3.left * 0.25f;
        if (Input.GetKey(KeyCode.S) || (Input.mousePosition.y < scrollArea && Input.mousePosition.y > 0))
            camPos += Vector3.down * 0.25f;
        if (Input.GetKey(KeyCode.D) || (Input.mousePosition.x > Screen.width - scrollArea && Input.mousePosition.x < Screen.width))
            camPos += Vector3.right * 0.25f;
        cam.transform.localPosition = camPos;

    }

    public void ShowLevel()
    {
        for (layer = 0; layer < 3; layer++)
        {
            for (yRegion = 0; yRegion < mapSideSizeInRegions; yRegion++)
            {
                for (xRegion = 0; xRegion < mapSideSizeInRegions; xRegion++)
                {
                    for (yChunk = 0; yChunk < regionSideSizeInChunks; yChunk++)
                    {
                        for (xChunk = 0; xChunk < regionSideSizeInChunks; xChunk++)
                        {
                            for (y = 0; y < chunkSideSizeInTiles; y++)
                            {
                                for (x = 0; x < chunkSideSizeInTiles; x++)
                                {
                                    ShowTile();
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void GenerateLevel()
    {
        level = new int[5, mapSideSizeInRegions, mapSideSizeInRegions, regionSideSizeInChunks, regionSideSizeInChunks, chunkSideSizeInTiles, chunkSideSizeInTiles];
        //layer 0
        layer = 0;
        
        //layer 1

        //layer 2

        //layer 3

        //layer 4
        layer = 4;
    }

    public void ShowTile()
    {
        if (layer < 3)
        {
            GameObject tile;
            SpriteRenderer sr;
            xAbs = ((xRegion * regionSideSizeInTiles) + (xChunk * chunkSideSizeInTiles) + x);
            yAbs = ((yRegion * regionSideSizeInTiles) + (yChunk * chunkSideSizeInTiles) + y);
            tile = new GameObject("tile" + xAbs.ToString() + "_" + yAbs.ToString());//create new tile
            tile.transform.localScale = new Vector2(1f, 1f);//set tile size
            sr = tile.AddComponent<SpriteRenderer>();//add a sprite renderer
            if (layer == 0)
            {
                switch (level[layer, xRegion, yRegion, xChunk, yChunk, x, y])
                {
                    case 1:
                        sr.sprite = l0t1;
                        break;
                    case 2:
                        sr.sprite = l0t2;
                        break;
                    case 3:
                        sr.sprite = l0t3;
                        break;
                    case 4:
                        sr.sprite = l0t4;
                        break;
                    case 5:
                        sr.sprite = l0t5;
                        break;
                    default:
                        sr.sprite = l0t0;
                        break;
                }
            }
            else if (layer == 1)
            {
                switch (level[layer, xRegion, yRegion, xChunk, yChunk, x, y])
                {
                    case 1:
                        sr.sprite = l1t1;
                        break;
                    case 2:
                        sr.sprite = l1t2;
                        break;
                    case 3:
                        sr.sprite = l1t3;
                        break;
                    case 4:
                        sr.sprite = l1t4;
                        break;
                    case 5:
                        sr.sprite = l1t5;
                        break;
                    case 6:
                        sr.sprite = l1t6;
                        break;
                    case 7:
                        sr.sprite = l1t7;
                        break;
                    case 8:
                        sr.sprite = l1t8;
                        break;
                    case 9:
                        sr.sprite = l1t9;
                        break;
                    case 10:
                        sr.sprite = l1t10;
                        break;
                    case 11:
                        sr.sprite = l1t11;
                        break;
                    case 12:
                        sr.sprite = l1t12;
                        break;
                    case 13:
                        sr.sprite = l1t13;
                        break;
                    case 14:
                        sr.sprite = l1t14;
                        break;
                    case 15:
                        sr.sprite = l1t15;
                        break;
                    case 16:
                        sr.sprite = l1t16;
                        break;
                    default:
                        GameObject.Destroy(tile);
                        break;
                }
            }
            if (layer == 2)
            {
                switch (level[layer, xRegion, yRegion, xChunk, yChunk, x, y])
                {
                    case 1:
                        sr.sprite = l2t1;
                        break;
                    case 2:
                        sr.sprite = l2t2;
                        break;
                    case 3:
                        sr.sprite = l2t3;
                        break;
                    case 4:
                        sr.sprite = l2t4;
                        break;
                    case 5:
                        sr.sprite = l2t5;
                        break;
                    case 6:
                        sr.sprite = l2t6;
                        break;
                    default:
                        GameObject.Destroy(tile);
                        break;
                }
            }
            tile.transform.position = new Vector3(xAbs * 0.64f, yAbs * 0.64f, 10);//place in scene based on level indices
        }
    }
}
