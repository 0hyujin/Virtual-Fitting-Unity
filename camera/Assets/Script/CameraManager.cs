using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public RawImage display;    // RawImage�� ī�޶� ���� ǥ��
    WebCamTexture camTexture;   // ī�޶� �Է��� �ޱ� ���� WebCamTexture ��ü

    private void Start()    //���� �Լ�
    {
        // ��� ������ ��� ī�޶� ����̽� ��������
        WebCamDevice[] devices = WebCamTexture.devices;

        // ù ��° ī�޶� ����̽� ��������
        WebCamDevice device = devices[0];

        // ����̽� �̸��� ����Ͽ� ���ο� WebCamTexture�� ����
        camTexture = new WebCamTexture(device.name, 1280, 720);

        //����̽��� ��� ȭ���� �� ã�� ���� �߻��߾��� -> RawImage�� ��� ������ ����
        display = FindObjectOfType<RawImage>();

        // display�� �ؽ�ó�� camTexture�� ����
        display.texture = camTexture;

        // ī�޶� ������ �޾ƿ��� ����
        camTexture.Play();
    }
}