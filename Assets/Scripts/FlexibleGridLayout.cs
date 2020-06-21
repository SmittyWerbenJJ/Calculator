using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(GridLayoutGroup))]
[RequireComponent(typeof(RectTransform))]
public class FlexibleGridLayout : MonoBehaviour
{
    private GridLayoutGroup _gridLayoutGroup;
    RectTransform _rectTransform;
    float _cellWidth;
    Vector2 _cellSize;



    private void Update()
    {


        _gridLayoutGroup = GetComponent<GridLayoutGroup>();
        _rectTransform = GetComponent<RectTransform>();
        if (!_gridLayoutGroup || !_rectTransform)
        {
            Debug.LogWarning(this.transform.name + "- No GridLayerGroup or RectTransform Found!");
            return;
        }


        var sqrt = Mathf.Sqrt(transform.childCount);
        switch (_gridLayoutGroup.constraint)
        {
            //Constant Cell WIDTH
            case GridLayoutGroup.Constraint.FixedColumnCount:
                _cellSize.x = _rectTransform.rect.width / _gridLayoutGroup.constraintCount;
                _cellSize.y = _rectTransform.rect.height / Mathf.CeilToInt(sqrt);
                break;

            //Constant Cell Height
            case GridLayoutGroup.Constraint.FixedRowCount:
                _cellSize.x = _rectTransform.rect.width / _gridLayoutGroup.constraintCount;
                _cellSize.y = _rectTransform.rect.height / _gridLayoutGroup.constraintCount;
                break;

            default: break;
        }
        //Apply Cell Spacing 
        _cellSize -= new Vector2(_gridLayoutGroup.spacing.x, _gridLayoutGroup.spacing.y);// Mathf.CeilToInt(sqrt);

        //Apply Cell Size XY
        _gridLayoutGroup.cellSize = _cellSize;

        //_gridLayoutGroup.spacing
    }
}
