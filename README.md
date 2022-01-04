# 윤미의 모험


<br>

## 🎙 introduction 🎙
섬을 돌아다니며 필요한 재료를 모아 무인도를 탈출하는 간단한 게임     
전체 파일 다운로드 : [구글 드라이브](https://drive.google.com/file/d/1ZbhW-PeTdEkoShdpjUIvcBCEDGx-LYBi/view?usp=sharing)


<br>

### 👤 Team Members
* 기능 구현 파트
  * 박서현 (캐릭터 움직임, 애니메이션 효과 구현)
  * 이재용 (AI 적 구현)
  * 차경훈 (인벤토리 및 상호작용 구현)      
* 맵, 시나리오 제작 파트
  * 정윤미
  * 유승우

### ⏰ Period     
* 2020.09.23 ~ 2020.12.16         

### ⚙️ Development environment
* Unity
* Visual Studio
* GitHub


<br>

---------------------------------------------------------------------

<br>

## 📝 Process 📝
![구성도](https://user-images.githubusercontent.com/50102522/147957155-b94acb9c-4a74-4cf0-9b7b-4d02cbafb408.png)

<br>

## 🎥 Demo 🎥
❗️ 유니티로 실행해보면 음악과 함께 다양한 기능을 테스트해볼 수 있습니다.

<br>

### 0️⃣ 게임 방법      
- 마우스로 **[게임 방법]** 버튼을 누르면 애니메이션 효과와 함께 화면이 이동됨.  

https://user-images.githubusercontent.com/50102522/148019086-6e23fb5a-8031-4fcb-a4a4-59e92df8a211.mp4


### 1️⃣ 게임 시작     
- 게임 시작 : 마우스로 **[게임 시작]** 버튼을 누르면 애니메이션 효과와 함께 게임이 시작됨.   
- 미션 확인 : 시작하면 화면에 미션이 공지되고, 키보드에서 o 버튼을 눌러 미션을 확인함.
- 미션 실행 : 아이템에 가까이 다가가면 바닥에 있던 아이템이 인벤토리로 이동 됨. (인벤토리 확인은 i 버튼을 누르면 됨.)

https://user-images.githubusercontent.com/50102522/148019100-ea7be754-f968-45d9-a162-eaba1ae2ddf4.mp4

### 2️⃣ 미션 완료
- 필요한 재료를 모두 모은 후, f 버튼을 누르면 엔딩 장면이 나옴.

|미션 완료|미션 성공(엔딩)|
|:--:|:--:|
|![clear](https://user-images.githubusercontent.com/50102522/148020475-14b826d1-a2d8-4f8a-95da-74c38702b647.png)|![ending](https://user-images.githubusercontent.com/50102522/148020485-afc2ddbd-4049-4637-b48c-201f2de1766a.png)|


### 3️⃣ 게임 오버
- 왼쪽 상단에 있는 체력이 다 닳으면 게임이 종료됨.
- 체력 고갈 조건
  - 적에게 맞았을 경우
  - 물 속에 들어간 경우
  - 높은 곳에서 떨어진 경우
