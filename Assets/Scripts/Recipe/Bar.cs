using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Bar : MonoBehaviour
{
    [SerializeField] private RecipeManager recipeManager;
    [SerializeField] private float timeToServe;
    private float _timeOnBar;
    private bool _isDishOnBar;

    private GameObject _dish;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isDishOnBar)
        {
            _timeOnBar += Time.deltaTime;
            if (_timeOnBar >= timeToServe)
            {
                recipeManager.ServeDish(_dish);
                _dish.GetComponent<Dish>().DeletingDish();
                _timeOnBar = 0;
                Destroy(_dish);
            }
        }
    }

    public void DishEnterBar(SelectEnterEventArgs dish)
    {
        _isDishOnBar = true;
        _dish = dish.interactableObject.transform.gameObject;
    }
    
    public void DishExitBar(SelectExitEventArgs dish)
    {
        _isDishOnBar = false;
        _timeOnBar = 0;
        _dish = null;
    }
}
