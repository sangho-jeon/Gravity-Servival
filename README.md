# Gravity Servival
#### (2020.1. ~)

>## Categori: Hypercasual

> ## Concept
> 행성들 사이로 player가 연료가 다 떨어질 때 까지 날아다니는 서바이벌형 캐주얼 게임입니다.

> ## Feature
> * Normal Planet
>   * 위치와 크기가 랜덤하게 생성되는 평범한 행성들입니다.
>   * 크기에 비례하게 각각의 중력이 생성됩니다.
>   * player와 일정거리 안에 있으면 행성의 중심 방향으로 player에게 중력이 작용합니다.
> * Big Planet
>   * 보통 행성보다 큰 크기를 가지고 있으며 중력 또한 큽니다.
>   * 큰 행성마다 Heal과 Boost 아이템이 공전합니다.
> * BlackHole
>   * 블랙홀은 Big Planet보다 큰 중력을 가지고 있으며, 탈출하기에 많은 연료가 소모되므로 조심해야 합니다.
> * Asteroid
>   * 게임을 진행함에 따라 난이도 조정을 목표로 1500점 이상을 넘으면 생성됩니다.
>   * 각 Asteroid는 player의 방향으로 움직이며 player와 충돌할시 체력이 깍이게 됩니다.
>
> ## Item
>  * Heal
>    * 빨간색 구체로 움직이지 않습니다.
>    * 획득시 player의 체력이 올라가게 됩니다.
>  * Boost 
>    * 보라색 구체로 각각의 기준으로 공전하고 있습니다.
>    * 획득시 일정시간동안 player의 이동속도가 증가하게 되며, player의 색상이 바뀌게 됩니다.
>
> ## UI
>  * 화면 중앙 상단에 현재의 스코어가 표시됩니다.
>  * 화면 왼쪽에 체력 표시 바가 있으며 이 체력바가 다 닳게 되면 게임이 오버됩니다.
>  * 체력바는 시간당 일정하게 감소하며, 플레이어가 연료를 소모하면서 움직이게 되면 체력바는 더 빨리 닳게 됩니다.
>  * 화면 오른쪽 상단에 설정 버튼이 있습니다.

<img src="img/main_page.png" width = 130px height = 100%></img>
<img src="img/game_page.png" width = 130px height = 100%></img>
<img src="img/setting_page.png" width = 130px height = 100%></img>
<img src="img/end_page.png" width = 130px height = 100%></img>


>현재는 Demo버전으로 animation, high score, sound 관련 이슈 수정 중