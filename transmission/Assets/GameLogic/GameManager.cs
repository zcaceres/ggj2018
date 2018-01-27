﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : NetworkBehaviour {
  private TimeController timeController;

//  void Start () {
//    SetUpComponents();
//    // When other player connects...
//    StartCoroutine(GetReady());
//    Debug.Log("Created Gallery of " + allRounds.Count() + " rounds. From codeblock of length " + codeBlock.Length);
//  }
//
//  IEnumerator GetReady() {
//    SetUpRound(allRounds);
//    PlayMusic();
//    streakNotifier.DisplayTextOnTopOfScreen((allRounds.Count() > 1 ? (allRounds.Count() + 1) + " Rounds" : "1 Round"), 3);
//    yield return new WaitForSecondsRealtime(2);
//    streakNotifier.DisplayTextOnTopOfScreen(codeBlock.Length + " Chars", 3);
//    yield return new WaitForSecondsRealtime(2);
//    announcer.PlayGetReadySound();
//    streakNotifier.DisplayTextOnTopOfScreen("Get Ready", 2);
//    yield return new WaitForSecondsRealtime(1);
//    streakNotifier.DisplayTextOnTopOfScreen("3", 1);
//    yield return new WaitForSecondsRealtime(1);
//    streakNotifier.DisplayTextOnTopOfScreen("2", 1);
//    yield return new WaitForSecondsRealtime(1);
//    streakNotifier.DisplayTextOnTopOfScreen("1", 1);
//    PlayReloadSound();
//    yield return new WaitForSecondsRealtime(1);
//    announcer.PlayBeginSound();
//    streakNotifier.DisplayTextOnTopOfScreen("BEGIN", 1);
//    StartRound();
//  }

  void Awake() {
    timeController = transform.GetComponent<TimeController>();
  }

//	void Start () {
//    timeController.StartTime(30);
//	}

}
