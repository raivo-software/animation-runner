using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    /*
     * Toteuta AnimationController -luokka:
     * 
     * 1. Hae GameObjectissa oleva Animator -komponentti. Voit käyttää GetComponent -funktiota.
     * 2. Hae GameObjectissa oleva PlayerController -komponentti. Voit käyttää GetComponent -funktiota.
     * 3. Käytä PlayerControllerin GetSpeed() -funktiota hakeaksesi pelaajan nopeuden.
     * 4. Käytä PlayerControllerin IsGrounded() -funktiota tarkastaaksesi onko pelaaja maan päällä.
     * 5. Animoi pelaaja asettamalla Animator -komponentin tilat seuraavilla ehdoilla. Voit käyttä Animator.Play() -funkiota tilan asettamiseksi:
     *   - Kun pelaaja ei ole maan päällä, niin tilan tulee olla "Jump"
     *   - Kun pelaajan nopeus on 0, tilan tulee olla "Idle"
     *   - Kun pelaajan nopeus on 0 - 5, niin tilan tulee olla "Walk"
     *     - Tilan ollessa "Walk", animaation nopeuden tulee olla puolet pelaajan nopeudesta (esim. jos pelaajan nopeus on 4 m/s, animaation nopeuden tulee olla 2)
     *   - Kun pelaajan nopeus on suurempi kuin 5, tilan tulee olla "Run"
     *     - Tilan ollessa "Run", animaation nopeuden tulee olla viidennes pelaajan nopeudesta (esim. jos pelaajan nopeus on 6 m/s, animaation nopeuden tulee olla 1.2)
     *     
     * VINKKI: Animaation nopeutta voit säätää muuttamalla Animator.speed -kenttää!
     */
}

class PlayerAnimatorStates
{
    public const string Run = "Run";
    public const string Walk = "Walk";
    public const string Idle = "Idle";
    public const string Jump = "Jump";
}