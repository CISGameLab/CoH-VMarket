using UnityEngine;
using System.Collections;
using System;

public class Item : IComparable<Item> {

	// Use this for initialization
	public string itemName;
	public float Cost;
	public Sprite itemImage;
	public float[] nutritionalFacts;
	public int numberOfItemsTaken;
	public float discountAmount=0;
	public bool addedToCart;
	public int GroupNumber;
	public int GroupItemCount;


	public Item(string newName, float newcost,Sprite newitemImage, float[] newNutritionalFacts, int newNumberofitemsTaken, float newdiscountAmount,bool newAddedtoCart,int newGroupNumber,int newGroupItemCount)
	{
		itemName = newName;
		Cost = newcost;
		itemImage = newitemImage;
		nutritionalFacts = newNutritionalFacts;
		numberOfItemsTaken = newNumberofitemsTaken;
		discountAmount = newdiscountAmount;
		addedToCart = newAddedtoCart;
		GroupNumber = newGroupNumber;
		GroupItemCount = newGroupItemCount;
	}

	public int CompareTo(Item other)
	{
		if(other == null)
		{
			return 1;
		}

		//Return the difference in power.
		return 0;
	}
}
