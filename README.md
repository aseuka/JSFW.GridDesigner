# JSFW.GridDesigner
그리드 디자이너 (( 💙 내가 가장 애정을 가진 프로그램 중 하나! 💙 ))

목적 : SI 프로젝트에서 그리드 관련 소스를 쉽게 구성하고 만들어낼 수 있도록 만든 프로그램.<br />
  - 디자이너로 그리드를 그려내고<br />
  - 확장dll로 설정된 그리드 정보로 소스생성기를 만들어낼 수 있게 만들었다. <br />
  
- 디자이너 화면<br />
 :: 하단 [테스트 확장기능임.], [디테일 컨트롤 작업], [스키마 추출], [EIS 테이블], [열거형 Columns] 등 각 버튼마다<br />
  확장 dll을 읽어서 동적으로 연계되는 버튼이다.<br />
![image](https://user-images.githubusercontent.com/116536524/198008999-bdf1cfbe-5d90-49ae-a5b7-8f7c1ecba140.png)

- 설정된 그리드 정보가 [테스트 확장기능임.] 버튼을 클릭하면 확장 개발로 구현된 곳에서 팝업처리 하였다.<br />
![image](https://user-images.githubusercontent.com/116536524/198009179-8b4530c2-62ce-4dd0-8a5d-a6d8229b3d8f.png)

- [테스트 확장기능임.] 버튼의 구현소스<br />
![image](https://user-images.githubusercontent.com/116536524/198009787-8445ba4e-84c5-43cd-bdc1-e8a57fa649cd.png)

- 프로젝트 하면서 저장된 그리드 디자인 정보<br />
  :: Extension -> 확장 dll들을 이 폴더에 배치하면 디자이너 실행시 동적으로 가져와 설정되고 클릭시 그리드 정보를 전달한다 <br />
![image](https://user-images.githubusercontent.com/116536524/199034487-9794b885-5056-406d-9d54-d3a87a59e157.png)
 
- 확장dll : [테스트 확장기능임.]을 구현한 dll<br />
![image](https://user-images.githubusercontent.com/116536524/198010651-2d80ded1-c39d-436f-9604-6fd9e5892bdd.png)

- 유튜브 영상<br />
[![IMAGE ALT TEXT](http://img.youtube.com/vi/yWpb4AxaVGE/0.jpg)](https://youtu.be/yWpb4AxaVGE?t=0s)

