# Unity_viking_run
Environment
	Platform：Unity 2020.3.21f
	Unity Version：Windows
	Editor：Visual Studio Code 1.63.2.0
How to use (play) your game
	WSAD：前/後/左/右 走路
	QE：左轉/右轉
	Space：跳躍
	Return：回到menu
Your game
	任何障礙物皆可用跳躍通過
	有其他維京人追你，跑快點喔~
	以金幣與時間為得分標準
Bonus
	Music 有背景音樂、維京人跑步、被抓到時的音效
	good structure design 敵人追逐的code
	
	public List<Vector3> positionList;
	void Update(){
		positionList.Add(transform.localPosition);
        	if (positionList.Count > distance)
        	{
            	positionList.RemoveAt(0);
            	petObject.transform.localPosition = positionList[0];
        	}
	} 
原本使敵人追逐玩家的code是用一個獨立物件來寫，有其速度方向，並會抓玩家位置，依照時間一步一步追。後來使用的演算法，用public List<Vector3> positionList在每次Update去存玩家位置，可以調控distance去決定存幾個vector後就可以去追玩家。直接把敵人的localPosition直接換成list裡面的位置。這樣寫兼具可以調控多就以後追玩家，比起之前的code此舉只需5行搞定，也清楚明瞭。

Some special game objects
	可以360度旋轉，擬真3D現實環境，皆可行走跳躍，並可用繞圈方式躲避敵人
	敵人也有動畫，可用倒退走的方式進行觀看
	被敵人抓到後，鎖定走路、旋轉與跳躍
How good your game is
	可以360度旋轉，擬真3D現實環境，皆可行走跳躍
	敵人的音效使玩家有被追逐的感覺，緊張刺激
	地圖設計上，有一些難關(如樓梯部分)，給予玩家一定的挑戰性
	障礙物不會破圖，有一再實驗過，會完全擋住玩家，使其只能跳躍
Feedback
	受益良多，期待付費課程

