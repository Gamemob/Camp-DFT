using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClueMove : MonoBehaviour
{
    public GameObject Canvas;
    private Vector2 mousePos;
    private bool picked;
    private Vector2 startPostion;
    public void Pick()
    {

    }
    private void Update()
    {

    }
}

namespace Common
{
    public class LimitUIDrag : MonoBehaviour, IBeginDragHandler, IDragHandler
    {
        [Header("��ʾ���Ƶ�����")]
        public RectTransform LimitContainer;
        [Header("������Canvas����Ҫ�޸Ļ�ȡ��ʽ")]
        public Canvas canvas;
        [Header("�����϶���UI����")]
        public RectTransform rt;
        // λ��ƫ����
        Vector3 offset = Vector3.zero;
        // ��С�����X��Y����
        float minX, maxX, minY, maxY;

        void Start()
        {
            canvas = GameObject.Find("UIRoot").transform.GetComponent<Canvas>();
        }
        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;
            if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, eventData.position, eventData.enterEventCamera, out Vector3 globalMousePos))
            {
                // ����ƫ����
                offset = rt.position - globalMousePos;
                // ������ק��Χ
                SetDragRange();
            }
        }
        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;
            // ����Ļ�ռ��ϵĵ�ת��Ϊλ�ڸ���RectTransformƽ���ϵ�����ռ��е�λ��
            if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, eventData.position, eventData.pressEventCamera, out Vector3 globalMousePos))
            {
                rt.position = DragRangeLimit(globalMousePos + offset);
            }
        }


        /// <summary>
        /// ���������С����
        /// </summary>
        void SetDragRange()
        {
            // ��Сx���� = ������ǰx���� - �������ľ�����߽�ľ��� + UI���ľ�����߽�ľ���
            minX = LimitContainer.position.x
                - LimitContainer.pivot.x * LimitContainer.rect.width * canvas.scaleFactor
                + rt.rect.width * canvas.scaleFactor * rt.pivot.x;
            // ���x���� = ������ǰx���� + �������ľ����ұ߽�ľ��� - UI���ľ����ұ߽�ľ���
            maxX = LimitContainer.position.x
                + (1 - LimitContainer.pivot.x) * LimitContainer.rect.width * canvas.scaleFactor
                - rt.rect.width * canvas.scaleFactor * (1 - rt.pivot.x);

            // ��Сy���� = ������ǰy���� - �������ľ���ױߵľ��� + UI���ľ���ױߵľ���
            minY = LimitContainer.position.y
                - LimitContainer.pivot.y * LimitContainer.rect.height * canvas.scaleFactor
                + rt.rect.height * canvas.scaleFactor * rt.pivot.y;

            // ���y���� = ������ǰx���� + �������ľ��붥�ߵľ��� - UI���ľ��붥�ߵľ���
            maxY = LimitContainer.position.y
                + (1 - LimitContainer.pivot.y) * LimitContainer.rect.height * canvas.scaleFactor
                - rt.rect.height * canvas.scaleFactor * (1 - rt.pivot.y);
        }

        /// <summary>
        /// �������귶Χ
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        Vector3 DragRangeLimit(Vector3 pos)
        {
            pos.x = Mathf.Clamp(pos.x, minX, maxX);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);
            return pos;
        }
    }
}

