## FIDO2 Sample

�ѦҦ�: https://github.com/passwordless-lib/fido2-net-lib#examples

## �Ѽ�
### userVerification (�ϥΪ����ҭn�D)
https://w3c.github.io/webauthn/#user-verification
https://w3c.github.io/webauthn/#enumdef-userverificationrequirement
	- required (�n�D�ϥΪ�����)
	- preferred (�ھڨϥΪ̦w���ʳ]�w�����ҡA�ϥΦ��]�w PIN�X or ����)
	- discouraged (�b�ާ@�������n�D���ҡA����ϥΦ��ϥι�����_ or �ͪ��G�����ҡA���ɤ��|����)
### requireResidentKey (�O�_�n�D���_�`�n�b�Ȥ��)
	- true (�O) PS ���� Windwos Hello Pin (�Y�� Pin �����A�h�`�n���_�]�|����)
	- false (�_)
https://w3c.github.io/webauthn/#dom-authenticatorselectioncriteria-requireresidentkey

## �y�{
1. ���U�˸m
	1.1 /makeCredentialOptions (�����API ���o���ҰѼ�)
	1.2  navigator.credentials.create (Web API �إ߾���)
	1.3 /makeCredential (�����API �x�s����)

2. �n�J
	2.1 /assertionOptions (�����API �����ұb���O�_�s�b�A�æ^�Ǿ��ҰѼ�)
	2.2 navigator.credentials.get (Web API ���o����)
	2.3 /makeAssertion (�N���ҶǦ^�������)
