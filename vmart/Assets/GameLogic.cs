using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameLogic : MonoBehaviour {

	// Use this for initialization
	public GameObject interactiveCH;
	public GameObject nonInteractiveCH;
	public Sprite tempSprite;
	public Sprite[] itemSprites;
	public GameObject[] itemsPickable;
	public GameObject itemPickPanel;
	public GameObject crosshhair;
	public GameObject ApplyCouponsBtn;
	public GameObject HintPanel;
	public GameObject[] sampleCartItems;
	public GameObject instantiatePoint;
	public GameObject infoPanel;

	public UnityEngine.UI.Text ItemListCart;
	public UnityEngine.UI.Text QuantityCart;
	public UnityEngine.UI.Text CPICart;
	public UnityEngine.UI.Text CouponAmtCart;
	public UnityEngine.UI.Text TotalCostList;
	public UnityEngine.UI.Text GrandTotalCost;

	public UnityEngine.UI.Text couponItems;
	public UnityEngine.UI.Text couponItemAmount;

	public UnityEngine.UI.Text NutritionFacts;
	public UnityEngine.UI.Text NutritionFactsTitle;

	public UnityEngine.UI.Text ConfirmPanelText;

	public UnityEngine.UI.Text hinttext;

	public List<Item> singleItem= new List<Item> ();

	public bool CouponsTaken;

	public GameObject couponPanel;
	public GameObject cartPanel;
	public GameObject CheckOutBtn;

	public float finalTotal;

	public bool isPanelOpen;


	void Start () {

		/*ArrayList juices = new ArrayList ();
		juices.Add ("OrangeJuice");
		juices.Add ("GrapeJuice");
		juices.Add ("AppleJuice");

		ArrayList Chocos_Cookies = new ArrayList ();
		Chocos_Cookies.Add ("DietCookies");
		Chocos_Cookies.Add ("MilkCookies");
		Chocos_Cookies.Add ("choclateCookies");
		Chocos_Cookies.Add ("CaramelChoclate");
		Chocos_Cookies.Add ("NutritionChoclates");


		ArrayList itemSets = new ArrayList ();
		itemSets.Add (juices);
		itemSets.Add ("Chocos_Cookies");
		itemSets.Add ("Meat");
		itemSets.Add ("Fruits_Tea_Coffee");
		itemSets.Add ("MilkProducts");
		itemSets.Add ("Wines");
		itemSets.Add ("Pizzas");
		itemSets.Add ("CheeseProducts");

		Debug.Log (itemSets[0]);
		ArrayList temp = new ArrayList ();
		temp = itemSets[0];
		Debug.Log (temp[1]);*/

		//Nutritional Facts = {Energy, Carbohydrate, total sugar, Protein, Total Fat, sat fatty acid, mono unsat, poly unsat, transfatty acid, total dietary fiber, sodium, calcium, unknown, unknow, unknown)
		float[] item1={571.0f,12.9f,0.0f,9.95f,28.6f,16.3f,1.4f,11.9f,0.0f,20.7f,557.0f,79.0f,0f,193.0f,0.0f};
		float[] item2={521.0f,23.9f,0.0f,2.95f,38.6f,26.3f,2.4f,12.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item3={511.0f,34.9f,0.0f,4.95f,48.6f,36.3f,3.4f,13.9f,0.0f,50.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item4={371.0f,45.9f,0.0f,5.95f,58.6f,46.3f,4.4f,14.9f,0.0f,60.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item5={56.0f,45.9f,0.0f,6.95f,36.6f,15.3f,5.4f,16.9f,0.0f,17.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item6={271.0f,56.9f,0.0f,8.95f,78.6f,66.3f,6.4f,11.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item7={173.0f,67.9f,0.0f,1.95f,88.6f,76.3f,7.4f,12.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item8={672.0f,78.9f,0.0f,2.95f,88.6f,86.3f,8.4f,13.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item9={170.0f,89.9f,0.0f,3.95f,78.6f,96.3f,9.4f,14.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item10={123.0f,89.9f,0.0f,4.95f,58.6f,16.3f,15.4f,16.9f,0.0f,10.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item11={434.0f,12.9f,0.0f,5.95f,48.6f,26.3f,2.4f,26.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item12={232.0f,23.9f,0.0f,6.95f,68.6f,36.3f,3.4f,36.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item13={123.0f,34.9f,0.0f,7.95f,78.6f,46.3f,4.4f,46.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item14={345.0f,45.9f,0.0f,1.95f,88.6f,56.3f,5.4f,56.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item15={423.0f,56.9f,0.0f,2.95f,98.6f,16.3f,6.4f,66.9f,0.0f,50.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item16={90.0f,67.9f,0.0f,4.95f,31.6f,17.3f,7.4f,76.9f,0.0f,16.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item17={122.0f,78.9f,0.0f,3.95f,28.6f,18.3f,8.4f,16.9f,0.0f,50.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item18={435.0f,87.9f,0.0f,4.95f,38.6f,16.3f,9.4f,26.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item19={324.0f,76.9f,0.0f,5.95f,48.6f,16.3f,1.4f,36.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item20={87.0f,65.9f,0.0f,9.95f,35.6f,17.3f,2.4f,14.9f,0.0f,13.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item21={345.0f,54.9f,0.0f,6.95f,68.6f,16.3f,3.4f,56.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item22={233.0f,43.9f,0.0f,7.95f,78.6f,14.3f,4.4f,66.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item23={112.0f,32.9f,0.0f,8.95f,88.6f,15.3f,5.4f,76.9f,0.0f,10.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item24={571.0f,21.9f,0.0f,5.95f,98.6f,16.3f,6.4f,46.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item25={234.0f,24.9f,0.0f,9.95f,08.6f,18.3f,7.4f,26.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item26={233.0f,35.9f,0.0f,3.95f,18.6f,19.3f,8.4f,36.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item27={122.0f,46.9f,0.0f,4.95f,28.6f,11.3f,9.4f,46.9f,0.0f,50.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item28={433.0f,67.9f,0.0f,5.95f,38.6f,26.3f,5.4f,56.9f,0.0f,60.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item29={123.0f,89.9f,0.0f,6.95f,48.6f,36.3f,5.4f,36.9f,0.0f,70.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item30={544.0f,36.9f,0.0f,7.95f,68.6f,46.3f,2.4f,46.9f,0.0f,60.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item31={122.0f,57.9f,0.0f,8.95f,78.6f,56.3f,3.4f,26.9f,0.0f,70.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item32={433.0f,45.9f,0.0f,1.95f,88.6f,66.3f,4.4f,36.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item33={65.0f,87.9f,0.0f,2.95f,39.6f,17.3f,5.2f,14.9f,0.0f,13.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item34={51.0f,24.9f,0.0f,3.95f,39.6f,17.3f,1.4f,15.9f,0.0f,12.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item35={57.0f,45.9f,0.0f,4.95f,30.6f,18.3f,3.4f,13.9f,0.0f,13.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item36={571.0f,43.9f,0.0f,5.95f,18.6f,96.3f,2.4f,26.9f,0.0f,20.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item37={522.0f,36.9f,0.0f,6.95f,28.6f,36.3f,3.4f,36.9f,0.0f,30.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item38={456.0f,58.9f,0.0f,7.95f,38.6f,46.3f,4.4f,46.9f,0.0f,40.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item39={94.0f,16.9f,0.0f,8.95f,34.6f,14.3f,5.4f,15.9f,0.0f,15.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item40={31.0f,35.9f,0.0f,6.95f,35.6f,15.3f,5.4f,16.9f,0.0f,16.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item41={771.0f,45.9f,0.0f,9.95f,68.6f,66.3f,5.4f,76.9f,0.0f,10.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item42={571.0f,45.9f,0.0f,3.95f,78.6f,76.3f,5.4f,86.9f,0.0f,70.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item43={122.0f,45.9f,0.0f,3.95f,88.6f,86.3f,5.4f,66.9f,0.0f,80.7f,557.0f,79.0f,5.3f,193.0f,0.0f};
		float[] item44={98.0f,45.9f,0.0f,2.95f,39.6f,18.3f,5.4f,16.9f,0.0f,18.7f,557.0f,79.0f,5.3f,193.0f,0.0f};






	
		//Debug.Log (singleItem[0].itemName+" "+singleItem[0].Cost+" "+singleItem[0].nutritionalFacts);

		/*foreach (float x in singleItem[0].nutritionalFacts) {
			Debug.Log (x);
		}*/

		//(new Item( Item Name, Price, Sprite, Nutritional Facts, unknown, unknown, unknown, group number, number of items in group)
		singleItem.Add (new Item("Orange Juice", 2.99f, itemSprites[30], item1, 0, 0.0f, false, 1, 3));
		singleItem.Add (new Item("Grape Juice",1.99f,itemSprites[20],item2,0,0.0f,false,1,3));
		singleItem.Add (new Item("Apple Juice",1.99f,itemSprites[1],item3,0,0.0f,false,1,3));

		singleItem.Add (new Item("Butter Cookies",3.50f,itemSprites[5],item4,0,0.0f,false,2,5));
		singleItem.Add (new Item("Milk Cookies",3.50f,itemSprites[43],item5,0,0.0f,false,2,5));
		singleItem.Add (new Item("Choco Cookies",3.50f,itemSprites[13],item6,0,0.0f,false,2,5));
		singleItem.Add (new Item("Dark Chocolate",1.29f,itemSprites[16],item7,0,0.0f,false,2,5));
		singleItem.Add (new Item("Fruit Chocolate",1.99f,itemSprites[19],item8,0,0.0f,false,2,5));

		singleItem.Add (new Item("Chicken",5.55f,itemSprites[11],item9,0,0.0f,false,3,7));
		singleItem.Add (new Item("Beef",9.55f,itemSprites[3],item10,0,0.0f,false,3,7));
		singleItem.Add (new Item("Lamb",13.55f,itemSprites[27],item11,0,0.0f,false,3,7));
		singleItem.Add (new Item("Fish",7.55f,itemSprites[18],item12,0,0.0f,false,3,7));
		singleItem.Add (new Item("Pork",8.55f,itemSprites[34],item13,0,0.0f,false,3,7));
		singleItem.Add (new Item("Roasted Fish",9.55f,itemSprites[37],item14,0,0.0f,false,3,7));
		singleItem.Add (new Item("Shrimp",10.55f,itemSprites[39],item15,0,0.0f,false,3,7));

		singleItem.Add (new Item("Lemon",4.55f,itemSprites[24],item16,0,0.0f,false,4,11));
		singleItem.Add (new Item("Cherry",3.55f,itemSprites[10],item17,0,0.0f,false,4,11));
		singleItem.Add (new Item("Apple",7.55f,itemSprites[2],item18,0,0.0f,false,4,11));
		singleItem.Add (new Item("Grapes",7.55f,itemSprites[21],item19,0,0.0f,false,4,11));
		singleItem.Add (new Item("Orange",8.55f,itemSprites[31],item20,0,0.0f,false,4,11));
		singleItem.Add (new Item("Lemon Tea",5.55f,itemSprites[41],item21,0,0.0f,false,4,11));
		singleItem.Add (new Item("Classic Tea",10.35f,itemSprites[14],item22,0,0.0f,false,4,11));
		singleItem.Add (new Item("Green Tea",10.55f,itemSprites[22],item23,0,0.0f,false,4,11));
		singleItem.Add (new Item("Dark Coffee",12.55f,itemSprites[17],item24,0,0.0f,false,4,11));
		singleItem.Add (new Item("Natural Coffee",8.55f,itemSprites[28],item25,0,0.0f,false,4,11));
		singleItem.Add (new Item("Refined Coffee",9.55f,itemSprites[36],item26,0,0.0f,false,4,11));

		singleItem.Add (new Item("Cow Milk",1.99f,itemSprites[15],item27,0,0.0f,false,5,8));
		singleItem.Add (new Item("Pasturized CowMilk",4.11f,itemSprites[32],item28,0,0.0f,false,5,8));
		singleItem.Add (new Item("Milk TetraPack",2.55f,itemSprites[26],item29,0,0.0f,false,5,8));
		singleItem.Add (new Item("Toned Milk",6.55f,itemSprites[25],item30,0,0.0f,false,5,8));
		singleItem.Add (new Item("Milk Pista Flavour",8.55f,itemSprites[33],item31,0,0.0f,false,5,8));
		singleItem.Add (new Item("Rose Milk",9.55f,itemSprites[38],item32,0,0.0f,false,5,8));
		singleItem.Add (new Item("American Butter",10.55f,itemSprites[0],item33,0,0.0f,false,5,8));
		singleItem.Add (new Item("Flavoured Butter",7.55f,itemSprites[23],item34,0,0.0f,false,5,8));

		singleItem.Add (new Item("Red Wine",25.55f,itemSprites[35],item35,0,0.0f,false,6,4));
		singleItem.Add (new Item("Cabernet",23.55f,itemSprites[6],item36,0,0.0f,false,6,8));
		singleItem.Add (new Item("Chardonnay",18.55f,itemSprites[7],item37,0,0.0f,false,6,8));
		singleItem.Add (new Item("Merlot",14.55f,itemSprites[42],item38,0,0.0f,false,6,8));

		singleItem.Add (new Item("Veg Pizza",30.55f,itemSprites[40],item39,0,0.0f,false,7,2));
		singleItem.Add (new Item("Chicken Pizza",35.55f,itemSprites[12],item40,0,0.0f,false,7,2));

		singleItem.Add (new Item("American Cheese",14.55f,itemSprites[4],item41,0,0.0f,false,8,4));
		singleItem.Add (new Item("Pecorino Cheese",9.55f,itemSprites[29],item42,0,0.0f,false,8,4));
		singleItem.Add (new Item("Manchego",7.55f,itemSprites[8],item43,0,0.0f,false,8,4));
		singleItem.Add (new Item("Camembert",8.55f,itemSprites[9],item44,0,0.0f,false,8,4));

		//Debug.Log (singleItem[0].nutritionalFacts[2]);

		//var x = singleItem.Find ("Mirinda");
		//Debug.Log (x);
	}
	
	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));
		RaycastHit hit;

		if (Input.GetKeyDown (KeyCode.I)) {
			if (infoPanel.gameObject.active == false)
			{
				infoPanel.gameObject.SetActive (true);
				cartPanel.gameObject.SetActive (false);
				couponPanel.gameObject.SetActive (false);
				itemPickPanel.gameObject.SetActive (false);
			}
		}

	

		if (Physics.Raycast (ray, out hit, 100)) {
			
			//Debug.Log (hit.point + " " + hit.collider.name);
			if (hit.collider.name == "Collider" && hit.distance <= 3) 
			{	
				interactiveCH.gameObject.SetActive (true);
				nonInteractiveCH.gameObject.SetActive (false);

				ApplyCouponsBtn.gameObject.SetActive (false);
				CheckOutBtn.gameObject.SetActive (false);

				if (cartPanel.gameObject.active == false && itemPickPanel.gameObject.active == false)
				{
					HintPanel.gameObject.SetActive (true);
					hinttext.text = "Press space to pick up items";
				}
				//Debug.Log (hit.collider.gameObject.tag);

				//List<Item> oneItemData= new List<Item> ();

				if (Input.GetKeyDown (KeyCode.Space) && isPanelOpen==false) 
				{
					Debug.Log (hit.collider.gameObject.tag);
					couponItems.text = "";
					couponItemAmount.text = "";
					HintPanel.gameObject.SetActive (false);
					for(int j=0;j<itemsPickable.Length;j++)
					{
						itemsPickable [j].gameObject.SetActive (false);
					}
					int i = 0;
					foreach (Item getItemData in singleItem) {
						if ((getItemData.GroupNumber).ToString() == hit.collider.gameObject.tag) {
						//Debug.Log (getItemData.itemName);
							crosshhair.gameObject.SetActive(false);
							this.gameObject.GetComponent<GameController> ().enabled = false;
							//this.gameObject.GetComponent<> ().enabled = false;
							itemPickPanel.gameObject.SetActive(true);
							isPanelOpen = true;
							itemsPickable [i].gameObject.SetActive (true);
							itemsPickable [i].gameObject.name = getItemData.itemName;
							itemsPickable[i].transform.GetChild(4).GetComponent<UnityEngine.UI.Text>().text=getItemData.itemName;
							var temp = itemsPickable [i].transform.GetChild (3);
							temp.transform.GetChild (0).GetComponent<UnityEngine.UI.Text>().text="$"+(getItemData.Cost).ToString();
							itemsPickable [i].GetComponent<UnityEngine.UI.Image> ().sprite = getItemData.itemImage;

							var temp2 = itemsPickable [i].transform.GetChild (2);
							temp2.gameObject.GetComponent<UnityEngine.UI.Text> ().text = (getItemData.numberOfItemsTaken).ToString();

							i++;
						}

						if (getItemData.discountAmount != 0) {
							couponItems.text += getItemData.itemName + "\n";
							couponItemAmount.text += (getItemData.discountAmount).ToString ("C") + "\n";
						}
					}
				}

			}
			else if (hit.collider.name == "InformationCenter" && hit.distance <= 3 && CouponsTaken==false) {	
				interactiveCH.gameObject.SetActive (true);
				nonInteractiveCH.gameObject.SetActive (false);

				ApplyCouponsBtn.gameObject.SetActive (false);
				CheckOutBtn.gameObject.SetActive (false);

				if (cartPanel.gameObject.active == false && itemPickPanel.gameObject.active == false) {
					HintPanel.gameObject.SetActive (true);
					hinttext.text = "Press space to pick up coupons";
				}
				//Debug.Log (hit.collider.gameObject.tag);

				//List<Item> oneItemData= new List<Item> ();

				if (Input.GetKeyDown (KeyCode.Space) && isPanelOpen==false) {
					//Debug.Log (hit.collider.gameObject.tag);
					CouponsTaken=true;
					itemPickPanel.gameObject.SetActive(true);
					HintPanel.gameObject.SetActive (false);
					isPanelOpen = true;
					for (int i = 0; i < 5; i++) {
						int randomNum = Random.Range (0,44);
						if (singleItem [randomNum].discountAmount == 0) 
						{
							//float ran2 = Random.Range (1.00f,(3/4)*singleItem [randomNum]);
							float ran2=Random.Range(1,(0.5f*singleItem[randomNum].Cost));
							singleItem [randomNum].discountAmount =ran2;
						} else
						{
							i--;
						}
					}
					int k = 0;
					foreach (Item getItemData in singleItem) {

						if (getItemData.discountAmount != 0 && k<=5) {
							couponItems.text += getItemData.itemName + "\n";
							couponItemAmount.text += (getItemData.discountAmount).ToString ("C") + "\n";
							k++;
						}

					}

				}

			} 
			else if (hit.collider.name == "CheckoutDesk" && hit.distance <= 3) {	
				interactiveCH.gameObject.SetActive (true);
				nonInteractiveCH.gameObject.SetActive (false);
				//Debug.Log (hit.collider.gameObject.tag);

				if (cartPanel.gameObject.active == false && itemPickPanel.gameObject.active == false) {
					HintPanel.gameObject.SetActive (true);
					hinttext.text = "Press space to pay and checkout";
				}

				//List<Item> oneItemData= new List<Item> ();

				if (Input.GetKeyDown (KeyCode.Space) && isPanelOpen==false) {
					//Debug.Log (hit.collider.gameObject.tag);
					isPanelOpen=true;
					viewCartClicked();
					cartPanel.gameObject.SetActive(true);
					if(CouponsTaken)
						ApplyCouponsBtn.gameObject.SetActive (true);
					CheckOutBtn.gameObject.SetActive (true);
					HintPanel.gameObject.SetActive (false);
				}

			} 
			else {
				interactiveCH.gameObject.SetActive (false);
				nonInteractiveCH.gameObject.SetActive (true);
				HintPanel.gameObject.SetActive (false);
			}
		}



	}

	public void increaseQuantity()
	{
		//Debug.Log (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.parent.name);
		var temp = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.parent;

		int currentQuantity = int.Parse(temp.GetChild (2).GetComponent<UnityEngine.UI.Text> ().text);

		currentQuantity++;
		temp.GetChild (2).GetComponent<UnityEngine.UI.Text> ().text = currentQuantity.ToString ();

		foreach (Item getItemData in singleItem) {
			if (getItemData.itemName == temp.name) {
				getItemData.numberOfItemsTaken = currentQuantity;
				Debug.Log (getItemData.itemName+" "+getItemData.numberOfItemsTaken);
			}
		}

	}

	public void ApplyCouponsClicked()
	{
		float grandtotal = 0.00f;
		ItemListCart.text = "";
		QuantityCart.text = "";
		CPICart.text = "";
		CouponAmtCart.text = "";
		TotalCostList.text = "";
		foreach (Item getItemData in singleItem) {
			if (getItemData.numberOfItemsTaken != 0) {
				ItemListCart.text += getItemData.itemName + "\n";
				QuantityCart.text += getItemData.numberOfItemsTaken+"\n";
				CPICart.text += "$"+getItemData.Cost + "\n";
				CouponAmtCart.text += "- "+(getItemData.discountAmount).ToString("C") + "\n";
				//CouponAmtCart.text += "- $0" + "\n";
				TotalCostList.text +="$"+(getItemData.numberOfItemsTaken*(getItemData.Cost-getItemData.discountAmount)).ToString()+"\n";
				grandtotal += getItemData.numberOfItemsTaken * (getItemData.Cost - getItemData.discountAmount);
				GrandTotalCost.text = "Final Amount - " + grandtotal.ToString ("C");
			}
		}
	}

	public void decreaseQuantity()
	{
		var temp = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.parent;
		int currentQuantity = int.Parse(temp.GetChild (2).GetComponent<UnityEngine.UI.Text> ().text);

		if(currentQuantity>0)
			currentQuantity--;
		temp.GetChild (2).GetComponent<UnityEngine.UI.Text> ().text = currentQuantity.ToString ();

		foreach (Item getItemData in singleItem) {
			if (getItemData.itemName == temp.name) {
				getItemData.numberOfItemsTaken = currentQuantity;
				Debug.Log (getItemData.itemName+" "+getItemData.numberOfItemsTaken);
			}
		}
	}

	public void itemClicked(){
		
		var temp = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.parent;
		//Debug.Log (temp.name);

		foreach (Item item in singleItem) {
			
			float[] nutFacts;
			if (temp.name == item.itemName) {
				//Debug.Log (item.Cost);
				nutFacts = item.nutritionalFacts;


				for(int i=0;i<nutFacts.Length;i++)
				{
					Debug.Log(nutFacts[i]);
					if (i == 0) {
						NutritionFacts.text = nutFacts [i].ToString () + " Kcal" + "\n";
						NutritionFactsTitle.text = "Nutritional Facts" + "\n" + "for " + item.itemName.ToString ();
					}
					else
						NutritionFacts.text += nutFacts [i].ToString() + " g" + "\n";
				}



			}
		}
	}

	public void viewCartClicked()
	{
		float grandtotal = 0.00f;
		ItemListCart.text = "";
		QuantityCart.text = "";
		CPICart.text = "";
		CouponAmtCart.text = "";
		TotalCostList.text = "";
		foreach (Item getItemData in singleItem) {
			if (getItemData.numberOfItemsTaken != 0) {
				ItemListCart.text += getItemData.itemName + "\n";
				QuantityCart.text += getItemData.numberOfItemsTaken+"\n";
				CPICart.text += "$"+getItemData.Cost + "\n";
				//CouponAmtCart.text += "- "+(getItemData.discountAmount).ToString("C") + "\n";
				CouponAmtCart.text += "- $0" + "\n";
				//TotalCostList.text +="$"+(getItemData.numberOfItemsTaken*(getItemData.Cost-getItemData.discountAmount)).ToString()+"\n";
				TotalCostList.text +="$"+(getItemData.numberOfItemsTaken*(getItemData.Cost)).ToString()+"\n";
				//grandtotal += getItemData.numberOfItemsTaken * (getItemData.Cost - getItemData.discountAmount);
				grandtotal += getItemData.numberOfItemsTaken * (getItemData.Cost);
				GrandTotalCost.text = "Final Amount - " + grandtotal.ToString ("C");
			}
		}
	}

	public void checkoutClicked()
	{
		foreach (Item getItemData in singleItem) {
			if (getItemData.numberOfItemsTaken != 0) {
				//ItemListCart.text += getItemData.itemName + "\n";
				//QuantityCart.text += getItemData.numberOfItemsTaken+"\n";
				//CPICart.text += "$"+getItemData.Cost + "\n";
				//CouponAmtCart.text += "-"+(getItemData.discountAmount).ToString("C") + "\n";
				//TotalCostList.text +="$"+(getItemData.numberOfItemsTaken*(getItemData.Cost-getItemData.discountAmount)).ToString()+"\n";
				finalTotal += getItemData.numberOfItemsTaken * (getItemData.Cost - getItemData.discountAmount);
				//GrandTotalCost.text = "Final Amount - " + finalTotal.ToString ("C");
			}
		}
		ConfirmPanelText.text = "Are you sure want to pay " +finalTotal.ToString("C") + " and proceed to checkout ?";
	}



	public void QuitClicked()
	{
		Application.Quit ();
	}

	public void ShopAgainClicked()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void setPanelFalse()
	{
		isPanelOpen = false;
	}

	public void CloseClicked()
	{
		//GameObject cartitem = (GameObject)Instantiate (sampleCartItems[Random.Range(0,9)]);
		//cartitem.transform.position = instantiatePoint.transform.position;
		//Debug.Log (cartitem.transform.name);
		sampleCartItems[Random.Range(0,9)].gameObject.GetComponent<MeshRenderer>().enabled=true;
	}

}
