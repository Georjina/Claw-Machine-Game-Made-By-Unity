<?
/////�����ͺ��̽� ������� ���� ����///////
$db_hostname="sky14786.cafe24.com";
$db_username="sky14786";
$db_password="whdkfk32!~";
$dbname = "sky14786";
/////�����ͺ��̽� ������� ���� ��///////

$sock = mysql_connect($db_hostname,$db_username,$db_password)
		or die ("�����ͺ��̽� ������ ������ �� �����ϴ�.");
$db = mysql_select_db($dbname,$sock)
		or die ("'$dbname' �����ͺ��̽��� ã�� �� ���ų� ���ٱ����� �����ϴ�.");
?>