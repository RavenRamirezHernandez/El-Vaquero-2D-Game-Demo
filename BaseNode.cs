using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class BaseNode : Node { 
	
    public virtual string GetString() {
        
        return null;
    }

    	public virtual Sprite GetSprite() {
		return null;
	}
}